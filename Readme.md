# Coding Challenge 1: Getting set up

## Introduction
Welcome to our first #XamarinAlliance coding challenge. Through a series of **coding challenges** you'll learn how to develop cross-platform mobile apps using Xamarin and also how you can integrate Azure services to make your apps **connected**. You can expect to see a new coding challenge become available every two weeks.

* [Challenge description](#description)
* [Template app](#templateapp)
* [Challenge details](#details)
* [Challenge completion](#completion)
* [Getting help](#gethelp)

If you encounter any issues make sure to check out our FATQ [(Frequently asked TECHNICAL questions)](https://github.com/msdxbelux/XamarinAlliance/blob/master/FAQ.md)

## <a name="description"></a>Challenge Description

The goal of this first coding challenge is to **set up your development environment for Xamarin development** and have a Xamarin up-and-running on your machine. This will be the basis for the next coding challenges, where you'll further expand the functionality of the app.

For those of you who have never used Xamarin or have no idea what app to build, we want to give you a head start by providing you a basic **Xamarin Alliance template app**. If, on the other hand, you already have experience in building Xamarin apps or you have a great idea in mind for an app, you can also complete the coding challenges by ***building your own app***.

Regardless of whether you use the template app or build your own, make sure to add some **creativity** to your coding challenges! Feel free to tweak the user interface and design, use other data sources or add more functionality to make your app really stand out. Throughout the coding challenges, we'll give you some ideas on how you could further improve the app.

With Xamarin you can build cross-platform mobile apps and you can do so on **Windows or Mac**, with Visual Studio or Visual Studio for Mac respectively. For doing the coding challenges, we leave it up to you to decice which platform you want to develop on.


## <a name="templateapp"></a>Xamarin Alliance Template App

The goal of the Xamarin Alliance template app is to allow the user to display the list of Star Wars characters.  In the first version of the app we'll only have a single list page which lists the different characters and some details, with no further interaction on these items. The character data is stored in a JSON document and packaged inside the app. In the next coding challenges, we'll improve and expand the functionality of the app.

The Xamarin Alliance template app has been built using [Xamarin Forms](https://www.xamarin.com/forms) and contains projects for Windows UWP and Android. You can remove any of these projects, depending on your development environment or preference (e.g. you cannot develop UWP on Mac). Also, if you prefer to build native app UIs instead of Xamarin Forms, you can do so too.

All data in the template app is courtesy of [StarWars.com](http://www.starwars.com/databank).

![Xamarin Alliance Template App](https://github.com/msdxbelux/XamarinAlliance/blob/master/Challenge%201/images/xa_screenshot1.jpg)


> **TIP:** if you're not into Star Wars, you could easily modify the app template to display recipes, movies, your favorite team's players, etc. Also, feel free to restyle the app, which is currently fairly bland.
  

## <a name="details"></a>Challenge Details

As mentioned, the goal of this coding challenge is to set up your development environment for Xamarin cross-platform development. To complete this coding challenge, you need to achieve the following steps:

1. Set up and install the development tools
2. Get/Develop an app
3. Get a Xamarin app running on your developer machine

### 1. Setup and install the tools

You can get started for free with Xamarin, as it is free in all editions of Visual Studio 2015. With the Visual Studio 2015 Community Edition, you have all the tools you need for free.

Depending on your preferences of OS and Visual Studio version, following one of the following guides to get your machine up-and-running for Xamarin development. These guides will ensure you have the developer tools as well as required mobile emulators on your machine.

* If you're using Visual Studio 2015 or install on a Mac, follow the [guide for getting set up](https://msdn.microsoft.com/en-us/library/mt613162.aspx) with Xamarin.
* If you want to use Visual Studio 2017 RC, follow [these instructions](https://developer.xamarin.com/guides/cross-platform/troubleshooting/questions/visualstudio-2017-rc/).
* If you want to use Visual Studio for Mac Preview, follow [these instructions](https://developer.xamarin.com/guides/cross-platform/visual-studio-mac/).

* If the installation fails, you can [perform a manual install](https://www.xamarin.com/faq#qxvs-installer-failing).

> **WARNING**: Xamarin is compatible with Visual Studio 2017 RC, however Xamarin cannot be used in earlier versions of Visual Studio on the same computer.


### 2. Get/Develop an app

**I want to use the Xamarin Alliance template app**

1. Download the source code from this GitHub repository.

    a) Navigate to the [Xamarin Alliance GitHub repo](https://github.com/msdxbelux/XamarinAlliance)

    b) Click the green 'Clone or download' button and either download the zip file or clone the repo using Git.

    ![Clone or download source code](https://github.com/msdxbelux/XamarinAlliance/blob/master/Challenge%201/images/xa_clone_download.jpg)
2. Unblock zip file (ignore this step if you've cloned the repo)

    Right-click the zip file in Windows Explorer and check the 'Unblock' checkbox and press 'OK'.
3. Extract the zip file onto your local disk (ignore this step if you've cloned the repo).
4. Open the solution in your IDE.
5. Optionally, modify the app template code to make it your own app. You can find out all the basics about building Xamarin Forms based apps [here](https://msdn.microsoft.com/en-us/library/mt679501.aspx).

> **TIP**: If in Visual Studio the Android and/or iOS project doesn't load and shows up as '(unavailable)', right-click the project and select **Reload project**.


**I'm building my own app**

1. Open up your IDE (Visual Studio or Xamarin Studio) and begin to write your app.


### 3. Run the app on your machine

In this step you'll run the app on your development machine. Depending on which platforms you want to support, you'll run the app for one or more platforms.

* To run the app for a given platform, you right-click the corresponding project, and select **Set as startup project**

![Set as startup project](https://github.com/msdxbelux/XamarinAlliance/blob/master/Challenge%201/images/xa_set_startup_project.jpg)

* Now select the appropriate **emulator** (or physical device) to run the app on and press F5.

![Select emulator](https://github.com/msdxbelux/XamarinAlliance/blob/master/Challenge%201/images/xa_emulator.jpg)

For a detailed description, check the [following guide](https://msdn.microsoft.com/en-us/library/mt488769.aspx) for verifying your installation.

> **TIP**: If you encounter the "Cannot connect to the debugger" when running on the VS Emulator for Android, follow the steps outlined [here](http://dotnetbyexample.blogspot.ru/2016/02/fix-for-could-not-connect-to-debugger.html).


## <a name="completion"></a>Challenge Completion

When you have completed your coding challenge, feel free to tweet about using the [#XamarinAlliance](https://twitter.com/hashtag/xamarinalliance) hashtag.

## <a name="gethelp"></a>Getting help

* Check the [Xamarin Forums](https://forums.xamarin.com/)
* Tweet hashtag [#XamarinAlliance](https://twitter.com/hashtag/xamarinalliance)
* Questions or issues? Check out the [FAQ](https://github.com/msdxbelux/XamarinAlliance/blob/master/FAQ.md) or [log an issue](https://github.com/msdxbelux/XamarinAlliance/issues)
