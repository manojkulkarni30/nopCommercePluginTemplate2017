# nopCommerce Plugin Template For Visual Studio 2017

[![Build status](https://ci.appveyor.com/api/projects/status/dy6emjvx4m5mq5hc?svg=true)](https://ci.appveyor.com/project/manojkulkarni30/nopcommerceplugintemplate2017)

<!-- Update the VS Gallery link after you upload the VSIX-->
Download this extension from the [VS Gallery](https://marketplace.visualstudio.com/items?itemName=ManojSunilKulkarni.nopCommercePluginTemplate-19038)
or get the [CI build](http://vsixgallery.com/extension/25083678-3c5d-4bbc-aee6-db34e90f70a8/).

---------------------------------------

nopCommerce Plugin project template for Visual Studio 2017. This project contains a simple class library project template  to get started quickly with nopCommerce plugin development. It adds basic content which are required for nopCommerce plugin like Description.txt, plugin configuration file etc.

See the [change log](CHANGELOG.md) for changes and road

## Project Template

In nopCommerce project, you just need to right click on Plugins folder and select Add => New Project option as shown below.

![Add New Plugin Project](https://raw.githubusercontent.com/manojkulkarni30/nopCommercePluginTemplate2017/master/ScreenShots/AddNewPluginProject.png)

It will open up the project dialog. Project template is visible under Visual C# => nopCommerce menu as shown below. 

![Project Dialog Window](https://raw.githubusercontent.com/manojkulkarni30/nopCommercePluginTemplate2017/master/ScreenShots/ProjectDialogWindow.png)

Select the nopCommerce Plugin Class Library project template, give it a name, make sure project location points to Plugins folder and then click on Ok button. After clicking on Ok button plugin project will be added under Plugins folder.

This project contains files like Description.txt, default logo image, plugin setting file, a controller, a view and web.config file as shown below.

![Project Content](https://raw.githubusercontent.com/manojkulkarni30/nopCommercePluginTemplate2017/master/ScreenShots/ProjectContent.png)

Build path for the project is also set to Nop.Web\Plugins folder and output path is also set for files like Description.txt, logo image, web.config and view. So that when you build plugin, content of the plugin will get copied to Nop.Web\Plugins folder as shown below.

![Compiled Plugin Content](https://raw.githubusercontent.com/manojkulkarni30/nopCommercePluginTemplate2017/master/ScreenShots/CompiledPlugin.png)

#### Note: You just need to change the version of nopCommerce according to your nopCommerce project version in Description.txt file. By default it is set as 3.90.

When you run the project and go to Plugins section in admin you will be able to see the plugin in admin section under Misc group as shown below.

![](https://raw.githubusercontent.com/manojkulkarni30/nopCommercePluginTemplate2017/master/ScreenShots/PluginList.png)

## Contribute
Check out the [contribution guidelines](CONTRIBUTING.md)
if you want to contribute to this project.

For cloning and building this project yourself, make sure
to install the
[Extensibility Tools 2017](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.ExtensibilityTools)
extension for Visual Studio which enables some features
used by this project.

## License
[MIT](LICENSE)