using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace faradzen.utils.Generic
{
    public class PropertyHelper
    {
        private readonly IEnumerable<PropertyInfo> _propKeys;

        public PropertyHelper(Type sourceType)
        {
            _propKeys = sourceType.GetProperties();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyPath">attrName1 or myFoo.attr2</param>
        /// <returns></returns>
        public Type GetPropertyType(string propertyPath)
        {
            if (string.IsNullOrEmpty(propertyPath))
            {
                throw new ArgumentNullException();
            }
            var pathKeys = propertyPath.Split('.').ToList();
            var result = GetPropertyTypeFirst(_propKeys, pathKeys);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyPath">simple path!</param>
        /// <returns></returns>
        private Type GetPropertyTypeFirst(IEnumerable<PropertyInfo> propKeys, List<string> propertyPath)
        {
            var lastpath = propertyPath.First();
            var lastPathType = propKeys.Single(s => s.Name == lastpath);
            if (propertyPath.Count == 1)
            {
                return lastPathType.PropertyType;
            }
            // dive next level
            var nextPathProps = lastPathType.PropertyType.GetProperties();
            propertyPath.RemoveAt(0);
            return GetPropertyTypeFirst(nextPathProps, propertyPath);
        }
    }
}
