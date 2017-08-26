////using Madplan.Extensions;



//public enum IngredientHelper
//{
//    [Description("Frisk æggehvide")]
//    Friskæggehvide,
//    [Description("1159")]
//    Friskæggehvide,
//    [MyDescription(Text = "281")]
//    Havregryn,
//    [MyDescription(Text = "711")]
//    Peberfrugt,
//    [MyDescription(Text = "1186")]
//    RevetOst,
//    [MyDescription(Text = "685")]
//    Olivenolie,
//    [MyDescription(Text = "Rapsolie")]
//    Rapsolie,
//    [MyDescription(Text = "1143")]
//    Æg,
//    [MyDescription(Text = "905")]
//    SkinkePålæg,
//    [MyDescription(Text = "1036")]
//    Tomat,
//    [MyDescription(Text = "1178")]
//    Pitabrød,
//    [MyDescription(Text = "882")]
//    Sennep,
//    [MyDescription(Text = "259")]
//    Gulerod,
//    [MyDescription(Text = "362")]
//    Hytteost,
//    [MyDescription(Text = "Rugflager")]
//    Rugflager,
//    [MyDescription(Text = "Æblemost")]
//    Æblemost,
//    [MyDescription(Text = "Æble")]
//    Æble,
//    [MyDescription(Text = "Hasselnødder")]
//    Hasselnødder,
//    [MyDescription(Text = "Honning")]
//    Honning,
//    [MyDescription(Text = "921")]
//    Skyr,
//    [MyDescription(Text = "1177")]
//    Granola,
//    [MyDescription(Text = "801")]
//    Rugbrød,
//    [MyDescription(Text = "Nøddepread")]
//    Nøddepread,
//    [MyDescription(Text = "Fuldkornsknækbrød")]
//    Fuldkornsknækbrød,
//    [MyDescription(Text = "Agurk")]
//    Agurk,
//    [MyDescription(Text = "Koncentreret solbærsaft")]
//    Solbærsaft,
//    [MyDescription(Text = "Rosiner")]
//    Rosiner,
//    [MyDescription(Text = "588")]
//    Mandler,
//    [MyDescription(Text = "Chiafrø")]
//    Chiafrø,
//    [MyDescription(Text = "Kanel")]
//    Kanel,
//    [MyDescription(Text = "Fintrevet citronskal")]
//    Citronskal,
//    [MyDescription(Text = "Mælk")]
//    Mælk,
//    [MyDescription(Text = "Friske Bær")]
//    Bær,
//    [MyDescription(Text = "Hummus")]
//    Hummus,
//    [MyDescription(Text = "Tørrende grønne ærter")]
//    TørrendeGrønneÆrter,
//    [MyDescription(Text = "Fed hvidløg")]
//    Hvidløg,
//    [MyDescription(Text = "Spidskommen")]
//    Spidskommen,
//    [MyDescription(Text = "Græskarkerner")]
//    Græskarkerner,
//    [MyDescription(Text = "Citron")]
//    Citron,
//    [MyDescription(Text = "AC-spread")]
//    ACspread,
//    [MyDescription(Text = "Fennikel")]
//    Fennikel,
//    [MyDescription(Text = "Parmaskinke")]
//    Parmaskinke,
//    [MyDescription(Text = "Frisk dild")]
//    Dild,
//    [MyDescription(Text = "Rugkerner")]
//    Rugkerner,
//    [MyDescription(Text = "Fishsauce")]
//    Fishsauce,
//    [MyDescription(Text = "Frisk basilikum")]
//    Basilikum,
//    [MyDescription(Text = "Skæreost")]
//    Skæreost,
//    [MyDescription(Text = "Æbleeddike")]
//    Æbleeddike,
//    [MyDescription(Text = "Fuldkornswrap")]
//    Fuldkornswrap,
//    [MyDescription(Text = "Spidskål")]
//    Spidskål,
//    [MyDescription(Text = "Kyllingbryst")]
//    Kyllingbryst,
//    [MyDescription(Text = "Karry")]
//    Karry,
//    [MyDescription(Text = "Tabasco")]
//    Tabasco,
//    [MyDescription(Text = "Kyllingelår")]
//    Kyllingelår,
//    [MyDescription(Text = "Lakridspulver")]
//    Lakridspulver,
//    [MyDescription(Text = "Grønne linser")]
//    GrønneLinser,
//    [MyDescription(Text = "Lime")]
//    Lime,
//    [MyDescription(Text = "Frisk Timian")]
//    Timian,
//    [MyDescription(Text = "Persillerod")]
//    Persillerod,
//    [MyDescription(Text = "Solsikkekerner")]
//    Solsikkekerner,
//    [MyDescription(Text = "Frisk persille")]
//    Persille,
//    [MyDescription(Text = "Sesamfrø")]
//    Sesamfrø,
//    //[MyDescription(Text = "Fuldkornspitabrød")]
//    //Fuldkornspitabrød,
//    [MyDescription(Text = "Kakaonibs")]
//    Kakaonibs,
//    [MyDescription(Text = "Pære")]
//    Pære,
//    [MyDescription(Text = "Mozzarella")]
//    Mozzarella,
//    [MyDescription(Text = "Kiwi")]
//    Kiwi,
//    [MyDescription(Text = "Mango")]
//    Mango,
//    [MyDescription(Text = "Frisk mynte")]
//    Mynte,
//    [MyDescription(Text = "Emmentaler")]
//    Emmentaler,
//    [MyDescription(Text = "Tun i vand")]
//    Tun,
//    [MyDescription(Text = "Radicchio")]
//    Radicchio,
//    [MyDescription(Text = "Kartofler")]
//    Kartofler,
//    [MyDescription(Text = "Drueagurker")]
//    Drueagurker,
//    [MyDescription(Text = "Makrel i tomat")]
//    Makrel,
//    [MyDescription(Text = "Oliven")]
//    Oliven,
//    [MyDescription(Text = "Cornichoner")]
//    Cornichoner,
//    [MyDescription(Text = "Majs")]
//    Majs,
//    [MyDescription(Text = "Hakkede tomater")]
//    HakkedeTomater,
//    [MyDescription(Text = "Frisk chili")]
//    Chili,
//    [MyDescription(Text = "Wontondej (el. folidej)")]
//    Wontondej,
//    [MyDescription(Text = "Torskerogn")]
//    Torskerogn,
//    [MyDescription(Text = "Radiser")]
//    Radiser,
//    [MyDescription(Text = "Karse")]
//    Karse,
//    [MyDescription(Text = "Fuldkornsbrød")]
//    Fuldkornsbrød,
//    [MyDescription(Text = "Blomkålsbuketter")]
//    Blomkålsbuketter,
//    [MyDescription(Text = "Rødløg")]
//    Rødløg,
//    [MyDescription(Text = "Hel dansk kylling")]
//    HelKylling,
//    [MyDescription(Text = "Nelliker")]
//    Nelliker,
//    [MyDescription(Text = "Aubergine")]
//    Aubergine,
//    [MyDescription(Text = "Pecorinoost")]
//    Pecorinoost,
//    [MyDescription(Text = "Bruse ris")]
//    BruneRis,
//    [MyDescription(Text = "Blå druer")]
//    BlåDruer,
//    [MyDescription(Text = "Laurbærblade")]
//    Laurbærblade,
//    [MyDescription(Text = "Hvidkål")]
//    Hvidkål,
//    [MyDescription(Text = "Laksefilet")]
//    Laksefilet,
//    [MyDescription(Text = "Avokado")]
//    Avokado,
//    [MyDescription(Text = "Frosne ærter")]
//    FrosneÆrter,
//    [MyDescription(Text = "Frisk ingegær")]
//    Ingegær,
//    [MyDescription(Text = "Kikærter")]
//    Kikærter,
//    [MyDescription(Text = "Wasabi")]
//    Wasabi,
//    [MyDescription(Text = "Sojasovs")]
//    Sojasovs,
//    [MyDescription(Text = "Syltede asier")]
//    SyltedeAsier,
//    [MyDescription(Text = "Rødkål")]
//    Rødkål,
//    [MyDescription(Text = "Rejer")]
//    Rejer,
//    [MyDescription(Text = "Grapefrugt")]
//    Grapefrugt,
//    [MyDescription(Text = "Torsk")]
//    Torsk,
//    [MyDescription(Text = "Knoldselleri")]
//    Knoldselleri,
//    [MyDescription(Text = "Jordskok")]
//    Jordskok,
//    [MyDescription(Text = "Vindruekerneolie")]
//    Vindruekerneolie,
//    [MyDescription(Text = "Vineddike")]
//    Vineddike,
//    [MyDescription(Text = "Purløg")]
//    Purløg,
//    [MyDescription(Text = "Hakket oksekød")]
//    HakketOksekød,
//    [MyDescription(Text = "Flåede tomater")]
//    FlåedeTomater,
//    [MyDescription(Text = "Grov paste")]
//    GrovPasta,
//    [MyDescription(Text = "Parmesanost")]
//    Parmesanost,
//    [MyDescription(Text = "Bønner i tomat")]
//    Bønner,
//    [MyDescription(Text = "Mørk øl")]
//    Øl,
//    [MyDescription(Text = "Mørk chokolade")]
//    Chokolade,
//    [MyDescription(Text = "Selleri")]
//    Selleri,
//    [MyDescription(Text = "Rødbeder")]
//    Rødbeder,
//    [MyDescription(Text = "Forårsløg")]
//    Forårsløg,
//    [MyDescription(Text = "Rispapir")]
//    Rispapir,
//    [MyDescription(Text = "Saltede peanuts")]
//    SaltedePeanuts,
//    [MyDescription(Text = "Jordnøddeolie")]
//    Jordnøddeolie,
//    [MyDescription(Text = "Hakket kalv og okse")]
//    HakketKalvOgOkse,
//    [MyDescription(Text = "Frosne edamamebønner")]
//    Edamamebønner,
//    [MyDescription(Text = "Frossen tomatpizza")]
//    Pizza,
//    [MyDescription(Text = "Forårsrulledej")]
//    Forårsrulledej,
//    [MyDescription(Text = "Små chorizopølser")]
//    Chorizopølser,
//    [MyDescription(Text = "Broccoli")]
//    Broccoli,
//    [MyDescription(Text = "Kalvekotelet med ben")]
//    Kalvekotelet,
//    [MyDescription(Text = "Hjertesalat")]
//    Hjertesalat,
//    [MyDescription(Text = "Rød appelsin")]
//    RødAppelsin,
//    [MyDescription(Text = "Svinekotelet")]
//    Svinekotelet,
//    [MyDescription(Text = "Oksebøf")]
//    Oksebøf,
//    [MyDescription(Text = "Eddike")]
//    Eddike,
//    [MyDescription(Text = "Rosmarin")]
//    Rosmarin,
//    [MyDescription(Text = "Fiskefilet")]
//    Fiskefilet,
//    [MyDescription(Text = "Mysli")]
//    Mysli,

//}
