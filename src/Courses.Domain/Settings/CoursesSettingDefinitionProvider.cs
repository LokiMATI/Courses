﻿using Volo.Abp.Settings;

namespace Courses.Settings;

public class CoursesSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CoursesSettings.MySetting1));
    }
}
