using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace People
{
    public interface Person
    {
        void SetLastName(string lastName);

        void SetFirstName(string firstName);

        void SetAge(string age);

        void SetMakeUpStories(string stories);

        string GetLastName();

        string GetFirstName();

        string GetAge();

        string GetMakingUpStories();
    }
}
