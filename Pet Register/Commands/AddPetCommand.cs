using Petclass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Register.Commands
{
    public  class AddPetCommand : CommandBase
    {

        public override bool CanExecute(object parameter) => parameter is not null and ObservableCollection<Pet>;

    }
}
