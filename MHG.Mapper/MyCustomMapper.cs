using System;
using System.Linq;

namespace MHG.Mapper {
    public static class MyCustomMapper {
        public static TTarget Map<TSource, TTarget>( this TSource source ) {
            Type sourceType = source.GetType();
            var target = Activator.CreateInstance<TTarget>();
            var targetType = target.GetType();
            var propsTarget = targetType.GetProperties();
            var propsSource = sourceType.GetProperties();
            for( int i = 0; i < propsTarget.Length; i++ ) {
                var targetProp = propsTarget[i];
                var sourceProp = propsSource.FirstOrDefault( T => T.Name == targetProp.Name );
                if( sourceProp != null ) {
                    var val = sourceProp.GetValue( source );
                    targetProp.SetValue( target, val );
                }
            }
            return target;
        }
    }
}
