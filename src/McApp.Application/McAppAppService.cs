using System;
using System.Collections.Generic;
using System.Text;
using McApp.Localization;
using Volo.Abp.Application.Services;

namespace McApp;

/* Inherit your application services from this class.
 */
public abstract class McAppAppService : ApplicationService
{
    protected McAppAppService()
    {
        LocalizationResource = typeof(McAppResource);
    }
}
