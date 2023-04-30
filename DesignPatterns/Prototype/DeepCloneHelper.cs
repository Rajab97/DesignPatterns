using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public static class DeepCloneHelper
    {
        public static T DeepClone<T>(T obj) where T : class
        {
            // If obj is null, return null
            if (obj == null)
                return null;

            // Get the type of obj
            Type type = obj.GetType();

            // If obj is a value type or a string, return obj
            if (type.IsValueType || type == typeof(string))
                return obj;

            // If obj is an array, create a new array and clone each element
            if (type.IsArray)
            {
                Type elementType = Type.GetType(
                    type.FullName.Replace("[]", string.Empty));
                var array = obj as Array;
                Array cloned = Array.CreateInstance(elementType, array.Length);
                for (int i = 0; i < array.Length; i++)
                    cloned.SetValue(DeepClone(array.GetValue(i)), i);
                return cloned as T;
            }

            // If obj is a reference type, create a new instance of the type
            // and clone each field recursively
            object result = Activator.CreateInstance(type);
            var fields = GetAllHierarcihalFields(type, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo field in fields)
            {
                object fieldValue = field.GetValue(obj);
                if (fieldValue == null)
                    continue;
                field.SetValue(result, DeepClone(fieldValue));
            }

            return result as T;
        }

        private static List<FieldInfo> GetAllHierarcihalFields(Type type,BindingFlags bindingFlags)
        {
            var fields = type.GetFields(
                bindingFlags).ToList() ;

            Type currentBaseType = type.BaseType;
            if (currentBaseType == typeof(object))
                return fields;

            while (currentBaseType != typeof(object))
            {
                var baseFields = currentBaseType.GetFields(bindingFlags);
                fields.AddRange(baseFields);

                currentBaseType = currentBaseType.BaseType;
            }
            return fields;
        }
    }
}
