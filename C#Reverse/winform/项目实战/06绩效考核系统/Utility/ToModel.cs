using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Utility {
    public static class ToModel {
        public static TModel DataRowToModel<TModel>(this DataRow dr) { 
            Type type = typeof(TModel);
            TModel o = (TModel)Activator.CreateInstance(type);
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties) {
                property.SetValue(o, dr[property.Name]);
            }
            return o;
        }
    }
}
