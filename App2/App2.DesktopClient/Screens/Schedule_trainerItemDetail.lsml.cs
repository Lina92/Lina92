using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class Schedule_trainerItemDetail
    {
        partial void Schedule_trainerItem_Loaded(bool succeeded)
        {
            // Добавьте сюда свой код.
            this.SetDisplayNameFromEntity(this.Schedule_trainerItem);
        }

        partial void Schedule_trainerItem_Changed()
        {
            // Добавьте сюда свой код.
            this.SetDisplayNameFromEntity(this.Schedule_trainerItem);
        }

        partial void Schedule_trainerItemDetail_Saved()
        {
            // Добавьте сюда свой код.
            this.SetDisplayNameFromEntity(this.Schedule_trainerItem);
        }
    }
}