using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentBuilder
{
    public class BuildPerson
    {
        public class Builder : PersonJobBuilder<Builder>
        {

        } 

        public static Builder New => new Builder();
    }
}
