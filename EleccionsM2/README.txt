DONE:________________________________________________________________________________
-button afegir muni, partit, candidat, taula(crearform per afegir)
-No s'em carrega be la llista de municipis.........he creat un button que fa refresh....................
-com afegir i eliminar un muni o partit o candidat?
-Textbox posar un maxim de lletres no?(ja esta capat per nums i lletres segons el cas)
-Controlar els valors nulls si la db es null es ralla el programa xd
-Controlar també si no hi han munciipis no pots crear taules ni partits i si no hi han partits no pots crear candidats..
(ho he fet amb lacces als buttons)

NEW TODO:____________________________________________________________________________
-QUE FER LOKO quan esta seleccinoat el primer municipi.. important
-PERQUE HE DE TERBALLAR DIRECTAMENT AMB EL CONTEXT EN EL MUNICIPI?XD


-el evento dataerror dels grid(solo surge en el primer seleccionado que es el que me esta jodiendoxd)
-ha d'haver tans regidors com candidats (validacio en candidats)
-Poder afegir resultats taula (per mes endavant)

DEMOMENTO HE TOCAT:_______________________________________________________________________________
-creatfuncio per els butons segons si la list esta plena o no de muni i partits
-he creat una altre que es diu inicializar per si no troba datos no peti xd
-Recordar Cridar la funcio de Grabar();
_____________________________________________________________________________________________
RUBEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEN:
-EEl tolist fa que no em peti el singleordefault que sencarrega de buscar lunic element que coincideix de la lista
i em diu que hi ha mes dun element que coincideix en canvi amb el tolist va bien..Randomxd
-AAbans amagava una columna del grid Taula perque dins de taula hi ha una clase que es resultats taula 
i es veia la ruta simplement osigui no es llegia.
-EEliminar municipio //Em passa lo mateix que amb el addmunicipio ho he de fer directe al context nose pq xd
-Intento ferho desde el gety set nose com va
-Amb elboto refresh conseguiexo que el grid municipios es refresqui que es lunic que no ho feiaPPPER
OPEROPEROPPPPPPPPPPERO no em va si vull fer resfresh si tinc el primer municipi selected.


_____________________________________________________________________________________________
-MILLORAR LA APP INOTIFYPROPERYCHANGED, POSARDIRECTE ELS CANSIS SIMPLEMENT ACTUALITZANT DIRECTE EN EL ATRIBUTS
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

