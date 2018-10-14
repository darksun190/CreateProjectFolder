using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateProjectFolder
{
    class ProjectInfo
    {
        public string Opportunity
        {
            get;
            private set;
        }
        public string Name
        {
            get;
            private set;
        }
        public ProjectInfo(string name, string opportunity)
        {
            Name = name;
            Opportunity = opportunity;
            initDirectory();
        }

        private void initDirectory()
        {
            string base_path = $"{Opportunity}_{Name}";
            CreateFolder.createFolder(base_path);
            //create level 1
            CreateFolder.createFolder($"{base_path}\\01_Customer Contact");

            CreateFolder.createFolder($"{base_path}\\02_Correspondence and Minutes");
            CreateFolder.createFolder($"{base_path}\\02_Correspondence and Minutes\\01_Customer");
            CreateFolder.createFolder($"{base_path}\\02_Correspondence and Minutes\\02_Supplier");
            CreateFolder.createFolder($"{base_path}\\02_Correspondence and Minutes\\03_Minutes");

            CreateFolder.createFolder($"{base_path}\\03_Schedule and Open Point List (OPL)");
            CreateFolder.createFolder($"{base_path}\\03_Schedule and Open Point List (OPL)\\01_Schedules");
            CreateFolder.createFolder($"{base_path}\\03_Schedule and Open Point List (OPL)\\02_OPL");

            CreateFolder.createFolder($"{base_path}\\04_Customer Data and Specification");
          

            CreateFolder.createFolder($"{base_path}\\05_Concept");
            CreateFolder.createFolder($"{base_path}\\05_Concept\\01_Overall Concept and Calculation");
            CreateFolder.createFolder($"{base_path}\\05_Concept\\02_Basic Unit");
            CreateFolder.createFolder($"{base_path}\\05_Concept\\03_Fixture");
            CreateFolder.createFolder($"{base_path}\\05_Concept\\04_Loading");
            CreateFolder.createFolder($"{base_path}\\05_Concept\\05_Cabin");
            CreateFolder.createFolder($"{base_path}\\05_Concept\\06_Application");
            CreateFolder.createFolder($"{base_path}\\05_Concept\\07_FACS");
            CreateFolder.createFolder($"{base_path}\\05_Concept\\08_Layout");
            CreateFolder.createFolder($"{base_path}\\05_Concept\\09_Feasibility Study");
            CreateFolder.createFolder($"{base_path}\\05_Concept\\10_Performance Tests");
            CreateFolder.createFolder($"{base_path}\\05_Concept\\11_Additional");

            CreateFolder.createFolder($"{base_path}\\06_Quotes");
            CreateFolder.createFolder($"{base_path}\\07_Customer Order");
            CreateFolder.createFolder($"{base_path}\\07_Customer Order\\01_Customer Order");
            CreateFolder.createFolder($"{base_path}\\07_Customer Order\\02_Final valid Concept, Specification, Layout");
            CreateFolder.createFolder($"{base_path}\\07_Customer Order\\03_Final valid Quote");
            CreateFolder.createFolder($"{base_path}\\07_Customer Order\\04_Negotiation Protocol");
            CreateFolder.createFolder($"{base_path}\\07_Customer Order\\05_Change orders");

            CreateFolder.createFolder($"{base_path}\\08_Kick-off");
            CreateFolder.createFolder($"{base_path}\\08_Kick-off\\01_Agenda and Presentation");
            CreateFolder.createFolder($"{base_path}\\08_Kick-off\\02_Minutes");

            CreateFolder.createFolder($"{base_path}\\09_Engineering and Programming");
            CreateFolder.createFolder($"{base_path}\\09_Engineering and Programming\\01_Engineering");
            CreateFolder.createFolder($"{base_path}\\09_Engineering and Programming\\02_Application");
            CreateFolder.createFolder($"{base_path}\\09_Engineering and Programming\\03_FACS");
            CreateFolder.createFolder($"{base_path}\\09_Engineering and Programming\\04_Additional");

            CreateFolder.createFolder($"{base_path}\\10_Acceptance and Hand-over");
            CreateFolder.createFolder($"{base_path}\\10_Acceptance and Hand-over\\01_Pre-Acceptance Supplier");
            CreateFolder.createFolder($"{base_path}\\10_Acceptance and Hand-over\\02_Pre-Acceptance Customer");
            CreateFolder.createFolder($"{base_path}\\10_Acceptance and Hand-over\\03_Customer Documentation");
            CreateFolder.createFolder($"{base_path}\\10_Acceptance and Hand-over\\04_Decleration of Conformity");
            CreateFolder.createFolder($"{base_path}\\10_Acceptance and Hand-over\\05_Commissioning (IBN)");
            CreateFolder.createFolder($"{base_path}\\10_Acceptance and Hand-over\\06_Operational Handover (BBÜ)");
            CreateFolder.createFolder($"{base_path}\\10_Acceptance and Hand-over\\07_Final Acceptance");
            CreateFolder.createFolder($"{base_path}\\10_Acceptance and Hand-over\\08_Hand-over to Service");

            CreateFolder.createFolder($"{base_path}\\11_Service");
            CreateFolder.createFolder($"{base_path}\\12_Lessons learned");

        }
    }
}
