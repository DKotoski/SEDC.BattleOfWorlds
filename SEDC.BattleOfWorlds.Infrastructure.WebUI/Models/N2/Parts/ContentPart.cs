using N2;
using N2.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEDC.BattleOfWorlds.Infrastructure.WebUI.Models.N2.Parts
{
    [PartDefinition]
    [WithEditableTemplateSelection(ContainerName = Defaults.Containers.Metadata)]
    public class ContentPart:PartBase
    {
        [EditableText]
        public string Title { get; set; }
    }
}