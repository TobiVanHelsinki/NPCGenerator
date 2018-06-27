using System;
using System.Collections.Generic;
using System.Text;

namespace NPCGenerator.Model
{
    enum PropertyTypes
    {
        String,
        Int,
        Color,
        Date,
        Boolean
    }
    static class PropertyTypeHelper
    {
        /// <summary>
        /// returns a default value based on a propertytype
        /// </summary>
        /// <param name="typ"></param>
        /// <returns></returns>
        public static object InitContent(PropertyTypes typ)
        {
            switch (typ)
            {
                case PropertyTypes.String:
                    return "";
                case PropertyTypes.Int:
                    return 0;
                case PropertyTypes.Color:
                    return null;
                case PropertyTypes.Date:
                    return DateTime.MinValue;
                case PropertyTypes.Boolean:
                    return false;
                default:
                    return null;
                    break;
            }
        }
    }
}
