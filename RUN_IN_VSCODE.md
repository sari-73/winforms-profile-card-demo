# تشغيل WinForms Profile Card Demo في VS Code

هذا المشروع واجهة **Windows Forms**؛ لذلك يعمل على **Windows فقط**. لا يمكن تشغيل واجهة WinForms على macOS أو Linux حتى لو ظهر الكود في VS Code.

## المتطلبات

1. ثبّت **.NET 8 SDK** من https://dotnet.microsoft.com/download/dotnet/8.0 .
2. ثبّت VS Code وإضافة **C# Dev Kit** من Microsoft.
3. افتح مجلد المستودع كاملًا، وليس مجلد `ControlExample` الداخلي فقط.

## التشغيل

افتح الطرفية داخل VS Code في جذر المستودع ثم نفّذ:

```powershell
dotnet restore .\ControlExample\ControlExample.sln
dotnet run --project .\ControlExample\ControlExample\ControlExample.csproj
```

أو اضغط `F5` واختر **Launch WinForms Profile Card**. إذا ظهرت رسالة تطلب اختيار Debugger، اختر **.NET / C#**.

## ملاحظات

- لا تستخدم إضافة Code Runner لتشغيل هذا المشروع؛ فهي مناسبة لملف كود منفصل ولا تتعامل جيدًا مع مشاريع WinForms متعددة الملفات.
- بعد تعديل واجهة Form1، أعد تشغيل `dotnet run` أو اضغط `F5` من جديد.
