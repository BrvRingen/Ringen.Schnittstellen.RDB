# Ringen.Schnittstellen
Interfaces zu Plattformen die Daten für Mannschaftskämpfe bereitstellen.


using Ringen.Schnittstellen.Contracts.Models;
using Ringen.Schnittstellen.Contracts.Services;


private IApiSaisonInformationen _apiSaisonInformationen;
private IApiErgebnisdienst _apiErgebnisdienst;
private IApiMannschaftskaempfe _apiMannschaftskaempfe;


var saisonListe = await _apiSaisonInformationen.Get_Saisons_Async();
var ligenListe = await _apiSaisonInformationen.Get_Ligen_Async(saisonId);

var mannschaftskampf = await _apiMannschaftskaempfe.Get_Mannschaftskampf_Async(saisonId, wettkampfId);
var mannschaftskaempfListe = await _apiMannschaftskaempfe.Get_Mannschaftskaempfe_Async(saisonId, ligaId, tableId);