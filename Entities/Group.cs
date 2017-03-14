using App.WinForm.Attributes;
using App.WinForm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
    
    
{

    [DisplayEntity(Localizable = true, DisplayMember = "Name")]
    [Menu]
    public class Group :BaseEntity

    {
        [DisplayProperty(Titre = "Name")]
        [EntryForm(Ordre = 1, WidthControl = 300)]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public string Name { get; set;}

        [DisplayProperty(Titre = "Description")]
        [EntryForm(Ordre = 2, WidthControl = 300)]
        [Filter]
        [DataGrid(WidthColonne = 100)]
        public string Description { get; set; }
    }
}
