using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.BussinesLogic
{
    class ReactionOnCard
    {

        public static void SuperAdmin()
        {
            var addForm = new AddUserForm();            
            addForm.ShowDialog();           
        }

        public static void Admin()
        {
            var controlForm = new ControlUsersForm();
            controlForm.ShowDialog();
        }
       
       
    }
}
