Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.Text.RegularExpressions

Namespace kotor_tool
    ' Stock English area names from ARE Name/dialog.tlk; exact room overrides from LYT membership.
    ' These are browsing metadata, not resource names or a runtime module resolver.
    Public NotInheritable Class MapModuleMetadata
        Private Shared ReadOnly K1Areas As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
            {"m01aa", "Endar Spire - Command Module"},
            {"m01ab", "Endar Spire - Starboard Section"},
            {"m02aa", "Taris - South Apartments"},
            {"m02ab", "Taris - Upper City North"},
            {"m02ac", "Taris - Upper City South"},
            {"m02ad", "Taris - North Apartments"},
            {"m02ae", "Taris - Upper City Cantina"},
            {"m02af", "Taris - Hideout"},
            {"m03aa", "Taris - Lower City"},
            {"m03ab", "Taris - Lower City Apartments"},
            {"m03ad", "Taris - Lower City Apartments"},
            {"m03ae", "Taris - Javyar's Cantina"},
            {"m03af", "Taris - Swoop Platform"},
            {"m03mg", "Taris - Swoop Track"},
            {"m04aa", "Taris - Undercity"},
            {"m05aa", "Taris - Lower Sewers"},
            {"m05ab", "Taris - Upper Sewers"},
            {"m08aa", "Taris - Davik's Estate"},
            {"m09aa", "Taris - Sith Base"},
            {"m09ab", "Taris - Sith Base"},
            {"m10aa", "Taris - Black Vulkar Base"},
            {"m10ab", "Taris - Black Vulkar Base"},
            {"m10ac", "Taris - Black Vulkar Base"},
            {"m11aa", "Taris - Hidden Bek Base"},
            {"m11ab", "Taris - Hidden Bek Base"},
            {"m12aa", "Ebon Hawk"},
            {"m12ab", "Ebon Hawk - Turret"},
            {"m13aa", "Dantooine - Jedi Enclave"},
            {"m14aa", "Dantooine - Courtyard"},
            {"m14ab", "Dantooine - Matale Grounds"},
            {"m14ac", "Dantooine - Grove"},
            {"m14ad", "Dantooine - Sandral Grounds"},
            {"m14ae", "Dantooine - Crystal Cave"},
            {"m15aa", "Dantooine - Ruins"},
            {"m16aa", "Dantooine - Sandral Estate"},
            {"m17aa", "Tatooine - Anchorhead"},
            {"m17ab", "Tatooine - Docking Bay"},
            {"m17ac", "Tatooine - Droid Shop"},
            {"m17ad", "Tatooine - Hunting Lodge"},
            {"m17ae", "Tatooine - Czerka Office / Tatooine - Swoop Registration"},
            {"m17af", "Tatooine - Cantina"},
            {"m17mg", "Tatooine - Swoop Track"},
            {"m18aa", "Tatooine - Dune Sea"},
            {"m18ab", "Tatooine - Sand People Territory"},
            {"m18ac", "Tatooine - Eastern Dune Sea"},
            {"m20aa", "Tatooine - Sand People Enclave"},
            {"m22aa", "Kashyyyk - Czerka Landing Port"},
            {"m22ab", "Kashyyyk - The Great Walkway"},
            {"m23aa", "Kashyyyk - Village of Rwookrrorro"},
            {"m23ab", "Kashyyyk - Woorwill's Home"},
            {"m23ac", "Kashyyyk - Worrroznor's Home"},
            {"m23ad", "Kashyyyk - Hall of the Chieftain"},
            {"m24aa", "Kashyyyk - Upper Shadowlands"},
            {"m25aa", "Kashyyyk - Lower Shadowlands"},
            {"m26aa", "Manaan - Ahto West"},
            {"m26ab", "Manaan - Ahto East"},
            {"m26ac", "Manaan - West Central"},
            {"m26ad", "Manaan - Docking Bay"},
            {"m26ae", "Manaan - East Central"},
            {"m26mg", "Manaan - Swoop Track"},
            {"m27aa", "Manaan - Sith Base"},
            {"m28aa", "Manaan - Hrakert Station"},
            {"m28ab", "Manaan - Sea Floor"},
            {"m28ac", "Manaan - Kolto Control"},
            {"m28ad", "Manaan - Hrakert Rift"},
            {"m33aa", "Korriban - Dreshdae"},
            {"m33ab", "Korriban - Sith Academy Entrance"},
            {"m34aa", "Korriban - Shyrack Caves"},
            {"m35aa", "Korriban - Sith Academy"},
            {"m36aa", "Korriban - Valley of Dark Lords"},
            {"m37aa", "Korriban - Tomb of Ajunta Pall"},
            {"m38aa", "Korriban - Tomb of Tulak Hord"},
            {"m38ab", "Korriban - Tomb of Marka Ragnos"},
            {"m39aa", "Korriban - Tomb of Naga Sadow"},
            {"m40aa", "Leviathan - Prison Block"},
            {"m40ab", "Leviathan - Command Deck"},
            {"m40ac", "Leviathan - Hangar"},
            {"m40ad", "Leviathan - Bridge"},
            {"m41aa", "Unknown World - Central Beach"},
            {"m41ab", "Unknown World - South Beach"},
            {"m41ac", "Unknown World - North Beach"},
            {"m41ad", "Unknown World - Temple Exterior"},
            {"m42aa", "Unknown World - Elder Settlement"},
            {"m43aa", "Unknown World - Rakatan Settlement"},
            {"m44aa", "Unknown World - Temple Main Floor"},
            {"m44ab", "Unknown World - Temple Catacombs"},
            {"m44ac", "Unknown World - Temple Summit"},
            {"m45aa", "Star Forge - Deck 1"},
            {"m45ab", "Star Forge - Deck 2"},
            {"m45ac", "Star Forge - Command Center"},
            {"m45ad", "Star Forge - Viewing Platform"},
            {"m46aa", "Prison"},
            {"m50aa", "Yavin Station"},
            {"stunt_ebocom", "M12aa"},
            {"stunt_levbridge", "m40ad"}
        }
        Private Shared ReadOnly K1Rooms As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
            {"m12aa_01c", "Ebon Hawk / M12aa"},
            {"m12aa_01d", "Ebon Hawk / M12aa"},
            {"m12aa_01f", "Ebon Hawk / M12aa"},
            {"m12aa_01h", "Ebon Hawk / M12aa"},
            {"m12aa_01m", "Ebon Hawk / M12aa"},
            {"m12aa_01n", "Ebon Hawk / M12aa"},
            {"m12aa_01o", "Ebon Hawk / M12aa"},
            {"m40ad_08d", "Leviathan - Bridge / m40ad"},
            {"m40ad_25a", "Leviathan - Bridge / m40ad"}
        }
        Private Shared ReadOnly K2Areas As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
            {"001ebo", "Ebon Hawk - Interior"},
            {"002ebo", "Ebon Hawk - Exterior Hull"},
            {"003ebo", "Ebon Hawk - Interior"},
            {"101per", "Peragus - Administration Level"},
            {"102per", "Peragus - Mining Tunnels"},
            {"103per", "Peragus - Fuel Depot"},
            {"104per", "Peragus - Asteroid Exterior"},
            {"105per", "Peragus - Dormitories"},
            {"106per", "Peragus - Hangar Bay"},
            {"107per", "Peragus - Hangar Bay Turret"},
            {"151har", "Harbinger - Command Deck"},
            {"152har", "Harbinger - Crew Quarters"},
            {"153har", "Harbinger - Engine Deck"},
            {"201tel", "Citadel Station - Dock Module"},
            {"202tel", "Citadel Station - Entertainment"},
            {"203tel", "Citadel Station - Residential 082 East"},
            {"204tel", "Citadel Station - Residential 082 West"},
            {"207tel", "Citadel Station - Cantina"},
            {"208tel", "Citadel Station - Bumani Exchange Corp."},
            {"209tel", "Czerka Offices"},
            {"211tel", "Citadel Station - Swoop Race Track"},
            {"220tel", "Citadel Station - Suburban"},
            {"221tel", "Citadel Station - Suburban"},
            {"222tel", "Citadel Station - Entertainment Module 081"},
            {"231tel", "Telos - Restoration Zone"},
            {"232tel", "Telos - Underground Base"},
            {"233tel", "Telos - Czerka Site"},
            {"261tel", "Telos - Polar Plateau"},
            {"262tel", "Telos - Secret Academy"},
            {"301nar", "Nar Shaddaa - Refugee Landing Pad"},
            {"302nar", "Nar Shaddaa - Refugee Quad"},
            {"303nar", "Nar Shaddaa - Docks"},
            {"304nar", "Nar Shaddaa - Jekk'Jekk Tarr"},
            {"305nar", "Nar Shaddaa - Jekk'Jekk Tarr Tunnels"},
            {"306nar", "Nar Shaddaa - Entertainment Promenade"},
            {"351nar", "Nar Shaddaa - Goto's Yacht"},
            {"371nar", "Nar Shaddaa Swoop Track"},
            {"400dxn", "Mandalorian Cache"},
            {"401dxn", "Dxun - Jungle Landing"},
            {"402dxn", "Dxun - Jungle"},
            {"403dxn", "Dxun - Mandalorian Ruins"},
            {"410dxn", "Dxun - Jungle Tomb"},
            {"411dxn", "Dxun - Sith Tomb"},
            {"421dxn", "Dxun - Blockade Turret"},
            {"501ond", "Onderon - Iziz Spaceport"},
            {"502ond", "Onderon - Merchant Quarter"},
            {"503ond", "Onderon - Iziz Cantina"},
            {"504ond", "Onderon - Sky Ramp"},
            {"505ond", "Onderon Turret"},
            {"506ond", "Onderon - Royal Palace"},
            {"510ond", "Onderon Swoop Race Track"},
            {"511ond", "Merchant Quarter"},
            {"512ond", "Iziz - Western Square"},
            {"601dan", "Dantooine - Khoonda Plains"},
            {"602dan", "Dantooine - Khoonda"},
            {"604dan", "Dantooine - Crystal Cave"},
            {"605dan", "Dantooine - Enclave Courtyard"},
            {"610dan", "Dantooine - Enclave Sublevel"},
            {"650dan", "Dantooine - Rebuilt Jedi Enclave"},
            {"701kor", "Korriban - Valley of Dark Lords"},
            {"702kor", "Korriban - Sith Academy"},
            {"710kor", "Korriban - Shyrack Cave"},
            {"711kor", "Korriban - Secret Tomb"},
            {"851nih", "Ravager - Command Deck"},
            {"852nih", "Ravager - Bridge"},
            {"853nih", "853NIH"},
            {"901mal", "Malachor V - Surface"},
            {"902mal", "Malachor V - Depths"},
            {"903mal", "Malachor V - Trayus Academy"},
            {"904mal", "Malachor V - Trayus Core"},
            {"905mal", "Malachor V - Trayus Crescent"},
            {"906mal", "Malachor V - Trayus Proving Grounds"},
            {"950cor", "Ebon Hawk - Interior"}
        }
        Private Shared ReadOnly K2Rooms As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)

        ' Group by the canonical area family; room labels can also list shared cutscene aliases.
        Public Shared Sub GetLevel(ByVal resRef As String, ByVal gameIndex As Integer, ByRef location As String, ByRef level As String)
            location = "Unidentified levels"
            level = "Unknown area"
            If (gameIndex <> 0 AndAlso gameIndex <> 1) OrElse String.IsNullOrWhiteSpace(resRef) Then Return
            Dim pattern As String = If(gameIndex = 0, "^(m[0-9]{2}[a-z]{2})_", "^([0-9]{3}[a-z]{3})(?:[a-z0-9_]|$)")
            Dim area As Match = Regex.Match(resRef.Trim(), pattern, RegexOptions.IgnoreCase Or RegexOptions.CultureInvariant)
            If Not area.Success Then Return
            level = area.Groups(1).Value.ToLowerInvariant()
            Dim title As String = Nothing
            Dim areas As Dictionary(Of String, String) = If(gameIndex = 0, K1Areas, K2Areas)
            If Not areas.TryGetValue(level, title) Then Return
            Dim separator As Integer = title.IndexOf(" - ", StringComparison.Ordinal)
            If separator < 0 Then
                location = title
                level = String.Empty
            Else
                location = title.Substring(0, separator)
                level = title.Substring(separator + 3).Replace(" / " & location & " - ", " / ")
            End If
        End Sub

        Public Shared Function GetModuleName(ByVal resRef As String, ByVal gameIndex As Integer) As String
            If (gameIndex <> 0 AndAlso gameIndex <> 1) OrElse String.IsNullOrWhiteSpace(resRef) Then Return String.Empty
            Dim name As String = resRef.Trim()
            If name.EndsWith(".mdl", StringComparison.OrdinalIgnoreCase) Then name = name.Substring(0, name.Length - 4)
            Dim result As String = Nothing
            Dim rooms As Dictionary(Of String, String) = If(gameIndex = 0, K1Rooms, K2Rooms)
            If rooms.TryGetValue(name, result) Then Return result
            Dim pattern As String = If(gameIndex = 0, "^(m[0-9]{2}[a-z]{2})_", "^([0-9]{3}[a-z]{3})(?:[a-z0-9_]|$)")
            Dim match As Match = Regex.Match(name, pattern, RegexOptions.IgnoreCase Or RegexOptions.CultureInvariant)
            If Not match.Success Then Return String.Empty
            Dim areas As Dictionary(Of String, String) = If(gameIndex = 0, K1Areas, K2Areas)
            If areas.TryGetValue(match.Groups(1).Value, result) Then Return result
            Return String.Empty
        End Function
    End Class
End Namespace
