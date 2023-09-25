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



NEW TODO:____________________________________________________________________________

-PROBELMA REAL: RESULTATSTAULA-> ELIMINARTAULA INDIVIDUAL NO VA (el problema em sembla qeu es dels vots per llista aqui)
form añadir taula (tornar al main-> Cancel·lar)
((taula.resultados o ActualResultado no hi ha res xddd why???))

-chequear si els escons a repartir que no es repeteixi (que jo ho faig per ordre ignorant laltre pero s ha 
de tenir en compte que potser hi ha un esco a reparir entre 2 partits pq ha coincidit "mirar-me això")



_________
-Aviso amarillo si no estan be la suma de vots con los vots totals.
-Seleccionar Escons mediante Partit ID no mediante votsTotals xddd! funcio AsignarEscons()
-Chequear amb mes datos si la lista 1 funciona correctamente--EM SEMBLA QUE VA<---------
-LISTA 2--->Viewmodel:TAULA: nomTaula, List<votsperpartit>(pp/ psoe/ vox/sumar),votsNulls, votsBlancs, %Escrotat, 
NºVotsEscrotats, Participació.



CONDICIONS:
-Ha d'haver tans regidors com candidats (validacio en candidats) """casifet""" he de fer el mínim.
-Que no es pugui crear infinitament?
-Seguretat?



DEMOMENTO HE TOCAT:_______________________________________________________________________________

-Recordar Cridar la funcio de Grabar();

_____________________________________________________________________________________________
-MILLORAR LA APP INOTIFYPROPERYCHANGED, POSARDIRECTE ELS CANSIS SIMPLEMENT ACTUALITZANT DIRECTE EN EL ATRIBUTS, ASYNCAWAIT, 
-buscador per trobar el municipi?xd
-quesitos pels percentatges dels partits.
