using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AlbanianXrm.SolutionPackager.Extensions
{
    static class DatabindExtensions
    {
        public static Binding Bind<T, TSource, TProperty>(this T target, Expression<Func<T, TProperty>> targetProperty, TSource source, Expression<Func<TSource, TProperty>> sourceProperty, bool formattingEnabled = false)
            where T : Control
            where TSource : INotifyPropertyChanged
        {
            var targetPropertyInfo = targetProperty.GetProperty();
            var sourcePropertyInfo = sourceProperty.GetProperty();
            var binding = target.DataBindings.Add(
                 targetPropertyInfo.Name,
                 source,
                 sourcePropertyInfo.Name,
                 formattingEnabled: formattingEnabled);

            targetPropertyInfo.SetValue(target, sourcePropertyInfo.GetValue(source));
            return binding;
        }
    }
}
