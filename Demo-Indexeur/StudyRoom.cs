using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexeur
{
    internal class StudyRoom
    {
        private Dictionary<string, Student> _students = new Dictionary<string, Student>();
        public string Name { get; set; }

        public Student this[string computerId]
        {
            get { 
                if(_students.ContainsKey(computerId)) return _students[computerId];
                return null;
            }
            set {
                if (!_students.ContainsKey(computerId)) return;
                _students[computerId] = value;
            }
        }

        public void InitDictionnary()
        {
            for (int i = 1; i <= 20; i++)
            {
                _students.Add($"FORMA11{((i < 10) ? "0" : "")}{i}", null);
            }
        }
    }
}
