using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using FavoriteTest.DTO;
using FavoriteTest.DTO.Favorite;
using Xamarin.Forms;

namespace FavoriteTest.ViewModels.Favorite
{
    public class FavoriteLandingPageViewModel : BaseViewModel
    {
        public INavigation _Navigation;
        public Command FavoriteLandingPageBackToHomeScreenCommand { get; set; }

        #region Add new data
        public Command FavoriteLandingPageAddNewDataImageButtonCommand { get; set; }
        #endregion

        private bool _IsNoData;
        public bool IsNoData
        {
            get
            {
                return _IsNoData;
            }
            set
            {
                _IsNoData = value;
                RaisePropertyChanged(nameof(IsNoData));
            }
        }

        private bool _IsHaveData;
        public bool IsHaveData
        {
            get
            {
                return _IsHaveData;
            }
            set
            {
                _IsHaveData = value;
                RaisePropertyChanged(nameof(IsHaveData));
            }
        }

        private bool _IsViewMode;
        public bool IsViewMode
        {
            get
            {
                return _IsViewMode;
            }
            set
            {
                _IsViewMode = value;
                RaisePropertyChanged(nameof(IsViewMode));
            }
        }

        private bool _IsEditMode;
        public bool IsEditMode
        {
            get
            {
                return _IsEditMode;
            }
            set
            {
                _IsEditMode = value;
                RaisePropertyChanged(nameof(IsEditMode));
            }
        }

        #region TabBar
        public ObservableCollection<FavoriteTabBarEntity> TabBarItems { get; set; }
        public Command<FavoriteTabType> TabSelectedCommand { get; set; }
        public FavoriteTabType favoriteTabType = FavoriteTabType.TransferPrompyPay; //default
        #endregion

        #region FavoriteList Items
        public ObservableCollection<FavoriteItemsEntity> FavoriteList_ItemsSource { get; set; }

        private readonly FavoriteTransferList transferFavoriteList;
        private readonly FavoriteTransferList topupFavoriteList;
        private readonly FavoriteTransferList billpayFavoriteList;
        private readonly FavoriteTransferList interTransferFavoriteList;
        #endregion


        public FavoriteLandingPageViewModel(INavigation Navigation)
        {
            _Navigation = Navigation;
            FavoriteLandingPageBackToHomeScreenCommand = new Command(FavoriteLandingPageBackToHomeScreenMethod);
            FavoriteLandingPageAddNewDataImageButtonCommand = new Command(FavoriteLandingPageAddNewDataImageButtonMethod);

            FavoriteList_ItemsSource = new ObservableCollection<FavoriteItemsEntity>();

            InitialFavoriteTabBar();
            TabSelectedCommand = new Command<FavoriteTabType>(TabSelected);
           
            #region First time get all data
            favoriteTabType = FavoriteTabType.TransferPrompyPay;
            transferFavoriteList = GetFavoriteTransferList(FavoriteTabType.TransferPrompyPay);
            topupFavoriteList = GetFavoriteTransferList(FavoriteTabType.TopUp);
            billpayFavoriteList = GetFavoriteTransferList(FavoriteTabType.BillPay);
            interTransferFavoriteList = GetFavoriteTransferList(FavoriteTabType.InternationalTransfer);

            if (transferFavoriteList.TotalRecord > 0)
            {
                IsNoData = false;
                IsHaveData = true;

                GetTransferFavoriteList(transferFavoriteList, true,false);
            }
            else
            {
                IsNoData = true;
                IsHaveData = false;
            }
            #endregion
        }

        #region Add new data all method
        private void FavoriteLandingPageAddNewDataImageButtonMethod(object obj)
        {
            //For Kanoon command na krub
            App.Current.MainPage.DisplayAlert("Add New Na krub", "Fav type = " + favoriteTabType, "Back");
        }
        #endregion

        public void TabSelected(FavoriteTabType tabType)
        {
            favoriteTabType = tabType;

            if (favoriteTabType == FavoriteTabType.TransferPrompyPay)
            {
                FavoriteList_ItemsSource.Clear();
                GetTransferFavoriteList(transferFavoriteList, true, false);
            }
            else if (favoriteTabType == FavoriteTabType.TopUp)
            {
                FavoriteList_ItemsSource.Clear();
                GetTransferFavoriteList(topupFavoriteList, true, false);
            }
            else if (favoriteTabType == FavoriteTabType.BillPay)
            {
                FavoriteList_ItemsSource.Clear();
                GetTransferFavoriteList(topupFavoriteList, true, false);
            }
            else if (favoriteTabType == FavoriteTabType.InternationalTransfer)
            {
                FavoriteList_ItemsSource.Clear();
                GetTransferFavoriteList(interTransferFavoriteList, true, false);
            }
        }

        private void GetTransferFavoriteList(FavoriteTransferList transferList,bool input_IsViewMode,bool input_IsEditMode)
        {
            int input_FavoriteNickNameColSpan = 1;
            if (input_IsViewMode == true)
                input_FavoriteNickNameColSpan = 2;

            foreach (var list in transferList.FavoriteTransfer)
            {
                FavoriteItemsEntity entity = new FavoriteItemsEntity
                {
                    FavoriteImageUrl = list.ImgPath,
                    FavoriteNickName = list.AccNickName,
                    FavoriteAccountNo = list.AccNo,

                    FavoriteNickNameColSpan = input_FavoriteNickNameColSpan,
                    IsViewMode = input_IsViewMode,
                    IsEditMode = input_IsEditMode
                };

                FavoriteList_ItemsSource.Add(entity);
            }
        }

        public void InitialFavoriteTabBar()
        {
            TabBarItems = new ObservableCollection<FavoriteTabBarEntity>();
            var favTypes = Enum.GetValues(typeof(FavoriteTabType));

            foreach (FavoriteTabType type in favTypes)
            {
                string tabName = null;

                switch (type)
                {
                    case FavoriteTabType.TransferPrompyPay:
                        tabName = "โอนเงิน";
                        break;
                    case FavoriteTabType.TopUp:
                        tabName = "เติมเงิน";
                        break;
                    case FavoriteTabType.BillPay:
                        tabName = "จ่ายบิล";
                        break;
                    case FavoriteTabType.InternationalTransfer:
                        tabName = "โอนเงินต่างประเทศ";
                        break;
                }

                TabBarItems.Add
                (
                    new FavoriteTabBarEntity
                    {
                        TabName = tabName,
                        Type = type
                    }
                );


                //switch (type)
                //{
                //    case FavoriteTabType.TransferPrompyPay:
                //        tabName = FavoriteResources.Favorite_tab_bar_1;
                //        break;
                //    case FavoriteTabType.TopUp:
                //        tabName = FavoriteResources.Favorite_tab_bar_2;
                //        break;
                //    case FavoriteTabType.BillPay:
                //        tabName = FavoriteResources.Favorite_tab_bar_3;
                //        break;
                //    case FavoriteTabType.InternationalTransfer:
                //        tabName = FavoriteResources.Favorite_tab_bar_4;
                //        break;
                //}

                //if (!tabName.IsNullOrEmptyOrWhiteSpace())
                //{
                //    TabBarItems.Add
                //    (
                //        new FavoriteTabBarEntity
                //        {
                //            TabName = tabName,
                //            Type = type
                //        }
                //    );
                //}
            }
        }

        private void FavoriteLandingPageBackToHomeScreenMethod(object obj)
        {
            LogOutAndClose();
        }

        private Task<Page> LogOutAndClose()
        {
            return _Navigation.PopAsync();
        }

        private FavoriteTransferList GetFavoriteTransferList(FavoriteTabType favType)
        {
            FavoriteTransferList favoriteTransferList = new FavoriteTransferList();

            if(favType == FavoriteTabType.TransferPrompyPay)
            {
                FavoriteTransferEntity entity1 = new FavoriteTransferEntity
                {
                    AccID = 1741,
                    CustID = "TVCARDU50",
                    FavType = 1,
                    BankCode = "025",
                    AccNo = "7771713328",
                    AccType = 1,
                    AccNickName = "TVCARD65 RUET123",
                    AccName = "นาย ทีวีการ์ดหกสิบห้า ฤทัยดี",
                    Currency = "THB",
                    AccDetail = null,
                    OrgID = null,
                    BusinessID = null,
                    TransferObjective = null,
                    TransferObjectiveOther = null,
                    FromName = null,
                    ToSMS = null,
                    ToEmail = null,
                    ToName = null,
                    ToAcc = null,
                    CountryCode = null,
                    OtherCountry = null,
                    ToBank = null,
                    BankAddress = null,
                    InterBankCode = null,
                    Memo = null,
                    ImgPath = "https://res.cloudinary.com/demo/image/upload/w_400,h_400,c_crop,g_face,r_max/w_200/lady.jpg",
                    Channel = 1,
                    Status = 1,
                    IbanCode = null,
                    BankAbbr = null,
                    BankNameTH = "ธ.กรุงศรีอยุธยา",
                    BankNameEN = "Bank of Ayudhya",
                    IsFCD = null,
                    ImgPathBytes = null,
                    CreatedBy = "TVCARDU50",
                    CreatedDate = new DateTime(),
                    UpdatedBy = "TVCARDU50",
                    UpdatedDate = new DateTime(),
                    ConfirmFlow = null,
                    ErrorCode = null,
                    ErrorMessage = null,
                    IsUnsuccessPage = false
                };
                FavoriteTransferEntity entity2 = new FavoriteTransferEntity
                {
                    AccID = 1952,
                    CustID = "TVCARDU50",
                    FavType = 2,
                    BankCode = "004",
                    AccNo = "2632992427",
                    AccType = 1,
                    AccNickName = "KBank Test User",
                    AccName = "TANILAE SIRAROTCHANAPAT",
                    Currency = "THB",
                    AccDetail = null,
                    OrgID = null,
                    BusinessID = null,
                    TransferObjective = null,
                    TransferObjectiveOther = null,
                    FromName = null,
                    ToSMS = null,
                    ToEmail = null,
                    ToName = null,
                    ToAcc = null,
                    CountryCode = null,
                    OtherCountry = null,
                    ToBank = null,
                    BankAddress = null,
                    InterBankCode = null,
                    Memo = null,
                    ImgPath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTr8hbJMPoCcTm9jss9otFgeL-zJx5Ve8mP1v3yq3oTl0FecoO6",
                    Channel = 1,
                    Status = 1,
                    IbanCode = null,
                    BankAbbr = null,
                    BankNameTH = "ธ.กสิกรไทย",
                    BankNameEN = "Kasikorn Bank",
                    IsFCD = null,
                    ImgPathBytes = null,
                    CreatedBy = "TVCARDU50",
                    CreatedDate = new DateTime(),
                    UpdatedBy = "TVCARDU50",
                    UpdatedDate = new DateTime(),
                    ConfirmFlow = null,
                    ErrorCode = null,
                    ErrorMessage = null,
                    IsUnsuccessPage = false
                };

                favoriteTransferList.FavoriteTransfer.Add(entity1);
                favoriteTransferList.FavoriteTransfer.Add(entity2);

                favoriteTransferList.TotalRecord = 2;
            }
            
            return favoriteTransferList;
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}