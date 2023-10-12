using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayeredArchitecture
{
    public class FList
    {
        public static void ListFunc(DataGridView DataPanel)
        {
            List<EntityPersonnel> PerList = LogicPersonnel.LLPersonnelList();
            DataPanel.DataSource = PerList;
        }
    }
}
