﻿Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Globalization
Imports System.Resources
Imports System.Windows

' Bir bütünleştirilmiş koda ilişkin Genel Bilgiler aşağıdaki öznitelikler kümesiyle
' denetlenir. Bütünleştirilmiş kod ile ilişkili bilgileri değiştirmek için
' bu öznitelik değerlerini değiştirin.

' Bütünleştirilmiş kod özniteliklerinin değerlerini gözden geçirin

<Assembly: AssemblyTitle("WpfApp1")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("WpfApp1")>
<Assembly: AssemblyCopyright("Copyright ©  2019")>
<Assembly: AssemblyTrademark("")>
<Assembly: ComVisible(false)>

'Yerelleştirilebilir uygulamalar oluşturmaya başlamak için,
'.vbproj dosyanızdaki <UICulture>CultureYouAreCodingWith</UICulture>
'bir <PropertyGroup> grubuna ayarlayın.  Örneğin, kaynak dosyalarınızda ABD ingilizcesi
'kullanıyorsanız, <UICulture>'ı "en-US" olarak ayarlayın.  Sonra alttaki
'NeutralResourceLanguage özniteliğinin açıklamasını kaldırın.  Alt satırdaki "en-US"i
'proje dosyasındaki UICulture ayarıyla eşleştirmek güncelleyin.

'<Assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)>


'ThemeInfo özniteliği temaya özgü ve genel kaynak sözlüklerinin nerede bulunabilir olduğunu tanımlar.
'1. parametre: Temaya özgü kaynak sözlüklerinin konumu
'(bir kaynak sayfada
' uygulama kaynak sözlüklerinde bulunamazsa kullanılır)

'2. parametre: Genel kaynak sözlüklerinin konumu
'(bir kaynak sayfada
'uygulama ve temaya özgü kaynak sözlükleri)
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)>



'Bu proje COM'un kullanımına sunulursa aşağıdaki GUID, typelib kimliği içindir
<Assembly: Guid("a59d402d-105e-4a8b-a19c-488f5d6b50b4")>

' Bir derlemenin sürüm bilgileri aşağıdaki dört değerden oluşur:
'
'      Ana Sürüm
'      İkincil Sürüm 
'      Yapı Numarası
'      Düzeltme
'
' Tüm değerleri belirtebilir veya varsayılan Derleme ve Düzeltme Numaralarını kullanmak için
' aşağıda gösterildiği gibi '*' kullanabilirsiniz:
' <Assembly: AssemblyVersion("1.0.*")>

<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
