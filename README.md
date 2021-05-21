# Random-80-s-images
A program that aims to create random images in the Memphis style. For the moment it is a crap but I hope to improve it.

The program generates random images containing geometric shapes. You can set the values ​​of the size of the final image and the quantity of images to be generated.
in the second form it is possible to create objects that will be used to create the texturebrushes that are used to color the various shapes.

The program is still in its infancy and is still not working very well. To optimize the randomization part, both as regards the colors and the coordinates where the shapes are generated.

The path generator used to create the textures must be adjusted as objects of type texturevalues ​​are always created with the same coordinates.
The manual texture generator should work like this:

every time I start the "buttonSave_Click" method the object is serialized inside the xml file, with the parameters I insert from the form including the coordinates of the points that I acquire with the "panelText_Click" method. The problem is that within the xml file the saved points are the same for all objects while I would like to have different values.


Il programma genera immagini casuali conteneti forme geometriche . Si possono impostare i valori delle dimesioni dell'immagine finale e la quantità di immagini da generare. 
nel secondo form è possibile creare degli oggetti che verranno usati per creare le texturebrush che servono per colorare le varie forme. 

Il programma è ancora all'inizio e non funziona ancora benissimo. Da ottimizzare la parte di randomizzazione , sia per quanto riguarda i colori sia per le coordinate dove vengono generate le forme. 

Il generatore di percorsi usati per creare le texture va aggiustato in quanto si creano oggetti di tipo texturevalues sempre le stesse coordinate.
Il generatore manuale di texture dovrebbe funzionare cosi: 

ogni volta che avvio il metodo "buttonSave_Click" l'oggetto viene serializzato all'interno del file xml, con i parametri che inserisco dal form comprese le coordinate dei punti che acquisisco con il metodo "panelText_Click". Il problema è che all'interno del file xml i punti salvati sono gli stessi per tutti gli oggetti mentre io vorrei avere valori diversi.
