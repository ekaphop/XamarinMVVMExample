using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace FavoriteTest.ViewModels.Base
{
    public abstract class ExtendedBindableObject : BindableObject
    {
        protected void RaisePropertyChanged<T>(Expression<Func<T>> property)
        {
            var name = GetMemberInfo(property).Name;
            OnPropertyChanged(name);
        }

        protected void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            storage = value;
            OnPropertyChanged(propertyName);
        }

        private MemberInfo GetMemberInfo(Expression expression)
        {
            MemberExpression operand;
            LambdaExpression lambdaExpression = (LambdaExpression)expression;
            if (lambdaExpression.Body as UnaryExpression != null)
            {
                UnaryExpression body = (UnaryExpression)lambdaExpression.Body;
                operand = (MemberExpression)body.Operand;
            }
            else
            {
                operand = (MemberExpression)lambdaExpression.Body;
            }
            return operand.Member;
        }

        protected void RaisePropertyChangedByOther(BindableObject bindableObject) =>
            bindableObject.PropertyChanged += (sender, e) => OnPropertyChanged(e.PropertyName);

        protected void RaisePropertyChangedByOther(BindableObject bindableObject, string overridePropertyName) =>
            bindableObject.PropertyChanged += (sender, e) => OnPropertyChanged(overridePropertyName);
    }
}
