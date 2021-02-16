using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw9
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class AccessLevelAttribute : Attribute
    {
        private readonly string accessLevel;
        public AccessLevelAttribute(string accessLevel)
        {
            this.accessLevel = accessLevel;
        }

        public string AccessLevel { 
            get { return accessLevel; }
        }
    }
}
