using N2;
using N2.Definitions;
using N2.Web.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEDC.BattleOfWorlds.Infrastructure.WebUI.Models.N2.Parts
{
    [SidebarContainer(Defaults.Containers.Metadata,100,HeadingText="Metadata")]
    public class PartBase:ContentItem,IPart
    {
    }
}