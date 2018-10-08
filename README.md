# Creating Four Beautiful Apps at Once with Xamarin.Forms

You read that title correct – you can create an app for iOS, Android, macOS, and UWP simultaneously using Xamarin.Forms.

[Xamarin.Forms](https://msou.co/bnx) has come a long way since the days of when its recommended use was only for simple apps and prototyping. In this session, Matt will show you the advances in Xamarin.Forms and how to utilize them to create beautiful apps yourself.

You will see the basic structure of a Xamarin.Forms app and how to use XAML and the built-in controls to create a UI. You'll learn about the MVVM pattern and data binding so information can be presented and modified between the UI and logic layer with ease. You'll walk through accessing platform specific native controls – from XAML! At the end of this session, you'll be able to create a beautiful app - make that four beautiful apps – with Xamarin.Forms!

## Slides

[Here you go!](slides/BeautifulApps.pdf)

## Demos

### UI Demo

In this first demo we took a look at the [basic project structure](https://msou.co/bny) for a Xamarin.Forms app. Noting how each of the platform projects (or the iOS and Android) had their own projects - this way you can still make changes to them. While the shared UI and logic had it's own project which the [platform projects reference](https://msou.co/bnz). This way all the shared code is ... well ... shared

After that, we explored the app we'll use for the demo throughout the talk and the [common user controls](https://msou.co/bn1) that make up a Xamarin.Forms app.

- The [`ListView`](https://msou.co/bn3) which displays items from an enumerable.
- The [`Label`](https://msou.co/bn4) which do as the they're named - display data.
- The [`TableView`](https://msou.co/bn7) which is a great way to accept data in an ordered fashion.
- [`Entry`](https://msou.co/bn5) and [`Editor`](https://msou.co/bn6) controls - single line and multi-line text entry.
- [`Buttons`](https://msou.co/bn2) - those things that you click on.

### MVVM Demo

One of the things that makes Xamarin.Forms great is the built-in MVVM framework. MVVM is just like MVC - just with more V's and less C's. :)

A major portion of MVVM is the [data binding](https://msou.co/bn0). This is where you map a value in a control to a variable in in the logic layer. Then, whenever one changes - the other updates automatically!

Another portion is [commanding](https://msou.co/bn8). It's very similar to data binding, but instead of tying a variable to a value of a control, you tie a control's event to an action behind the scenes. So not only will Forms take care of subscribing and unsubscribing to the event for you (so no memory leaks), but you can also automatically specify when the action is valid - or when the event is available to be fired (based on other variables), and the framework will automatically take care of enabling or disabling the control for you.

### CSS Demo

One of the new features added in Xamarin.Forms 3.0 is the ability to style your controls using [CSS](https://msou.co/bn9). Yes, that [CSS](https://msou.co/bn9)!

If you're familiar with CSS from the web, you'll feel right at home with the Xamarin.Forms syntax of CSS.

There are subtle differences when styling controls versus setting the properties directly - such as not all of the Xamarin.Forms properties are available to be styled, and the names of the property names are different when setting them in CSS - but all in all they obey the usual CSS syntax.

All of the selectors that you're used to are available, such as class selectors, control type selectors, and element ID selectors. And the cascading rules of CSS also apply as well!

## Summary

Xamarin.Forms is a great way to build an app by writing your UI once, using the most commonly used controls and their events. However, you're not limited to only to the common controls that Forms provides, you can also access [platform specific features](https://msou.co/bnz) easily too.

Forms also provides a full featured MVVM framework, a [messaging service](https://msou.co/boa), a [dependency service](https://msou.co/bob), [CSS](https://msou.co/bn9) styling, and an [animation API](https://msou.co/boc) as well.

All in all, when considering building your next app, Forms merits a look!