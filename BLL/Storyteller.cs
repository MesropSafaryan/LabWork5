using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.ExceptionClass;

namespace BLL
{
    [Serializable]
    public class Storyteller : Human
    {
        public string StoryTellLevel { get; set; }
    }
}