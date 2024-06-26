# TedEncrypt File Encryption Tool
A GUI-based file encryption tool written in C# that makes use of the .NET framework. Files in the current directory are encrypted bytewise according to an unconditionally secure stream cipher with a generated key, rendering them completely unintelligible. They can only be decrypted if the key is placed into the current directory.


## Download and Use (Standalone .exe file)
The program in its easy 'click-to-run' .exe file can be  downloaded [here](https://github.com/Patterbear/TedEncrypt/releases/download/v1.0.0/TedEncrypt.exe).

To install, simply place the file into the directory whose files you wish to encrypt/decrypt.

### Disclaimer
Chrome will sometimes flag the download as suspicious and Microsoft may try and prevent it running.

The program's code is open for anybody to view and it is impossible for the program to modify any files that the user shouldn't/doesn't want to be modifying.

### Encryption
Run the 'TedEncrypt.exe' file in the directory whose files you wish to encrypt. If it is your first time encrypting in this directory, read the information before proceeding. Press the 'Encrypt' (or 'Proceed') button to encrypt the files.

A 'key' file will be generated and will be used to encrypt the files. Once encryption is complete, move the key file to a secure, separate location.


### Decryption
Move the key file back to the directory whose files you wish to decrypt. Run the 'TedEncrypt.exe' executable and press 'Decrypt'. As long as the correct key file is present, the files will decrypt.
