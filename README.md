#Aplicación de introducción a Webcomponents en Polymer y VisualStudio

Esta aplicación ha sido creada para la charla de Introducción al desarrollo web orientado a Webcomponents.
Se trata de la típica aplicación TodoList utilizando Webcomponents de Polymer y backend en ASP.NET

El objetivo de la aplicación es educativo, por lo que se ha redactado y comentado el código para facilitar su comprensión.

Si queréis conocer más en detalle la estructura de la aplicación, podéis echar un vistazo a las slides de la charla en el siguiente link:
[http://www.slideshare.net/ruchavarri/introduccin-webcomponents-y-visual-studio-58397647](http://www.slideshare.net/ruchavarri/introduccin-webcomponents-y-visual-studio-58397647)

Para poner en marcha la aplicación desde línea de comandos, solo hay que seguir dos pasos:

* Descargarse la versión especifica de DNX para .NET Framework: (ej: 1.0.0-rc1-update1)
```
dnvm install 1.0.0-rc1-update1
```

* Asegurarnos con que versión de dependencias estamos usando (ej: 1.0.0-rc1-update1):
```
dnvm use -r clr -arch x86 1.0.0-rc1-update1
```

* Ejecutar la aplicación mendiante DNX:
```
dnx web
```

Espero que os resulte util
