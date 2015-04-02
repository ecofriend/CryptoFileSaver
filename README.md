# CryptoFileSaver
A program to copy files that were not affected by cryptowall variants.


#### PROVIDED AS IS, WITHOUT SUPPORT OR WARRANTY

I created this program for our small IT company where a few of our clients were hit by the cryptowall ransomware. It was designed to work under specific conditions 
but I am making it available here in case it proves useful to someone else.

Please refer to http://www.bleepingcomputer.com/virus-removal/cryptowall-ransomware-information for additional information.

To get the registry entries with the list of encrypted files, have a look at 
http://www.bleepingcomputer.com/virus-removal/cryptowall-ransomware-information#list

###### Make sure to copy the files to a computer that has up to date AV protection and that is NOT a production machine.
When copying unencrypted files from a Cryptwall affected drive, my AV software did throw some warnings about possible 
infections that remained on the drive even though cryptowall (and variants) supposedly remove themselves after encrypting 
your data.

You can compile the source using the freely available Visual Studio 2013 Community Edition (https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx). 

Feel free to modify the program as you see fit.
