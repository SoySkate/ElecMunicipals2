DONE:________________________________________________________________________________
-button afegir muni, partit, candidat, taula(crearform per afegir)
-No s'em carrega be la llista de municipis.........he creat un button que fa refresh....................
-com afegir i eliminar un muni o partit o candidat?
-Textbox posar un maxim de lletres no?(ja esta capat per nums i lletres segons el cas)
-Controlar els valors nulls si la db es null es ralla el programa xd
-Controlar també si no hi han munciipis no pots crear taules ni partits i si no hi han partits no pots crear candidats..
(ho he fet amb lacces als buttons)
-suposadament solved: -QUE FER LOKO quan esta seleccinoat el primer municipi.. 
-no permetre crear un municipi amb un 0 de num regidors.
-Mirar de fer el delete on cascade alla el eleccionsviewmodel. Potser ve daqui lerror nose xd. NO funcionava nose be pq ho he fet a ma xd
-repasar funcio: passarPartitsVotsViewModel() done
_____________________________________________________________________________________________
RUBEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEN:
La funcio eliminar municipis no em funciona be del tot hi han dos candidats que no saaben deliminar nose perque y es posa en null
en la database.
ELIMINARTAULES I PARTITS FUNCIONA PERO EL CANDIDATS NO FUNCIONA EM PETA LOKO  <--------
{{{Al eliminar el candidat, i al voler eliminar els resultats taula peta el grid i tot nose. tal i com ho tinc ara funciona una mica xd}}}

NEW TODO:____________________________________________________________________________
//TODO: notworking el form de Resultats
fer un viewmodel per el form de votstotals per pasar el votstotals al actualresultat del form resultats. ;)
-Fer una altre funcio que getDataGridResults i convertirho del VotsPerLListaVM AL--> votsPerLlista 
 i enviarho a la lista del dbset.
-Els votsBlanc i VotsNull no han entrat encara tampoc (que llegeixi tot junt la list i els dos aquests).
-Pasar els partits al votsperllistaviewmodel y aixi es vegin al form de Resultats.



CONDICIONS:
-ha d'haver tans regidors com candidats (validacio en candidats) """casifet""" he de fer el mínim.
-Que no es pugui crear infinitament?
-Seguretat?

-Si no hi ha res posar en readonly lo altre (per exemplequan elimino tot)


DEMOMENTO HE TOCAT:_______________________________________________________________________________

-Recordar Cridar la funcio de Grabar();



_____________________________________________________________________________________________
-MILLORAR LA APP INOTIFYPROPERYCHANGED, POSARDIRECTE ELS CANSIS SIMPLEMENT ACTUALITZANT DIRECTE EN EL ATRIBUTS, ASYNCAWAIT, 
-buscador per trobar el municipi?xd


































DONE:____________________________________________________________________________
-estructura clases
-interfaz de entrada datos
-keypress eventos hasta el nombreCandidat.
-boton CarregarDades y CrearMunicipi los unicos que estan.
-Al afegir el partit politic nomes safegeix un els altres no safegeixen xd nose (no guardava bé els changes)
-Crear el objeto muncipio y poder ponerle data no consigo hacerlo. (debo acceder al objeto que he creado...)
-Per al boto de afegir partit un cop s hagin introduit el numero de candidats segons el numero de regidors el proxim enter
pot apretar el boto de afegirPartit en contes dapretarlo amb el click.
-Tambe restringir lletres als llocs o nomes han danar numeros.
-Seguir con los eventos de keypress para ir avanzando segun se mete data en los textbox.
-permetre eliminar en qualsevol moment a l hora de crear i carregar dades(MUNICIPI) i la del partit eliminar tambe 
els candidats que te el partit..etc
HEAVY: per eliminar el municipi he hagut de fer include de tota la merda que te dins a l hora de carregarlo xd claro.
mi autismo avanza por momentos ;)))))))))) ajajaja crzaymotosierra. 
-buton close panel azuldata
-buton carregardata .show panel data azul i mirar com es veura la data. xd
-fer funcio per borrar tot en la memoria+(crear funcions en les clases per borrar les dades del objecte)

TODO:____________________________________________________________________________


-Ara falta comprobar que funcioni i fer la pantalla ce carregar on pugui veure totes les dades i editarles i eliminarles
desde allà.

-CREC QUE ES MILLOR FERHO AL PANEL NORMAL EN COMPTES DEL BLAU..dios niideaMostrar les dades al panel blau i poder editarles eliminarles i una opcio que sigui posar vots o algo aixi xd
-¡pensar la millor forma de veure els datos i editarlos o eliminarlos!


---RESTRINGIR TAB el tabulador para no hacer lo mismo que el Enter. pq sino hace lo mismo visualmente pero
no hace la misma logica. por ejemplo si pongo valor en cens taula y no en nom taula y le doy enter se peta creo xd
MAYBE RESTINGINT L'ACCES ALS TEXTBOX EXCEPTE AL QUE TOCA PER ORDRE i manejarho amb el focus?
POTSER RESTRINGINT EL RATOLI NOMES PER ELS TEXT AIXI NOMES PUC ANAR FENT ENTER PER PASAR DE TEXTBOXS
---IMPORTANT-> SI FAIG CLICK A UN ALTRE TEXTBOX EN COMPTES DE PASAR AMB EL ENTER OBLIDO FUNCIONS PEL MIG...!!!!!!!!!!!!!!!



----Interfaz un panel por encima que muestre todos los municipios que hay en el dbset(
en la database y con todos los datos necesarios para que se vea bien).

----FER UN ALTRE FORM? PER INTRODUIR RESULTATS I FER LES OPERACIONS AQUELLES

--FINAL	millorar amb el tema async await i tota la pesca que encara nose com va

