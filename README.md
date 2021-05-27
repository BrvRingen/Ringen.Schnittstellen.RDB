# Ringen.Schnittstellen.RDB
## Getting started

```c#
var settings = new RdbSystemSettings("http://test.rdb.ringen-nrw.de", new NetworkCredential("",""));
StartUp.Init(settings);
```



**Beispiel**: Abrufen eines Mannschaftskampfes

```c#
List<Mannschaftskampf> wettkampfListe = await _apiMannschaftskaempfe.Get_Mannschaftskaempfe_Async("2019", "Oberliga", "Westfalen");
```