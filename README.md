<img src="https://nshackblog.files.wordpress.com/2020/03/hostbase.png" height="154px" width="200px" /><br />
A Sitecore Host example solution which can be used as a starting point for [Sitecore Host](https://doc.sitecore.com/developers/92/sitecore-experience-manager/en/sitecore-host.html) applications. Currently runs in the IdentityServer Host as a plugin, but will be updated when standalone Sitecore Host applications become readily available.

## Setup Instructions
1. Install [Sitecore Experience Platform 9.3 Initial Release](https://dev.sitecore.net/Downloads/Sitecore_Experience_Platform/93/Sitecore_Experience_Platform_93_Initial_Release.aspx)
2. Copy your Sitecore license to **YOUR_WEB_ROOT**\\**PREFIX**.identityserver.dev.local\sitecoreruntime
3. Clone project and build
4. Project will compile to _**YOUR_CLONE_LOCATION**\Hostbase.Plugin\bin\Debug\Hostbase.Plugin.1.0.0.nupkg_
5. Unpack _Hostbase.Plugin.1.0.0.nupkg_ and copy following files to the _**YOUR_WEB_ROOT**\\**PREFIX**.identityserver.dev.local_ folder from step 1
    - copy _lib\netstandard2.0\Hostbase.Plugin.dll_ to **YOUR_WEB_ROOT**\\**PREFIX**.identityserver.dev.local\sitecoreruntime\production
    - copy _content\sitecore\Hostbase.Plugin\config\settings.xml_ to **YOUR_WEB_ROOT**\\**PREFIX**.identityserver.dev.local\sitecoreruntime\production\sitecore\Hostbase.Plugin\config
    - copy _sitecore\Sitecore.Plugin.manifest_ to **YOUR_WEB_ROOT**\\**PREFIX**.identityserver.dev.local\sitecoreruntime\production\sitecore\Hostbase.Plugin

#### Using Host Base:
Visit _https://**MY_SC_INSTANCE**.identityserver.dev.local/Account/Login_

When you open the identity server logs you should see two messages:

>The SettingOne value is: 1  
>Plugin is running, name is: Hostbase.Plugin  
>Application name is: Sitecore.IdentityServer.Host

The app simply reads settings from [settings.xml](https://github.com/muso31/Hostbase/tree/master/Hostbase.Plugin/sitecore/Hostbase.Plugin/config/settings.xml) and outputs the value. It also outputs the Plugin name and Host application name. 

You can see these values being logged in [ConfigureSitecore.cs](https://github.com/muso31/Hostbase/tree/master/Hostbase.Plugin/ConfigureSitecore.cs). Host Base will be expanded but this basic example is enough to get you up and running.
