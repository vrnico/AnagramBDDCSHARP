# Anagram Checker

#### .Net MVC app that takes in a single word, and a list of words. The app then determines whether the list of words are anagrams of the primary word.

#### _By Nico Daunt_

## Description

_This is an Epicodus practice project for week 2 of the C# course. Its purpose is to display understanding .Net MVC testing in C#._

#### _Anagram_
* Checks whether or not inputted list contains anagrams of inputted word.


### Specifications

* Takes in a string.
  * sample input : "evil"
  * sample output : "evil"
* Takes in a list.
  * sample input : "live, vile, veil, veal"
  * sample output : "live, vile, veil, veal"
* Creates an array of both words.
  * sample input : "evil" "live, vile, veil, veal"
  * sample output : "e, v, i, l" "l, i, v, e| v, i, l, e| v, e, i, l| v, e, a, l"
* Compares arrays and determines whether or not the list contains anagrams of the primary word inputted.
  * sample input: "evil" "live, vile, veil, veal"
  * sample output: "confirmed" "confirmed, confirmed, confirmed, rejected"


## Setup/Installation Requirements

* _Clone this GitHub repository_

```
git clone https://github.com/vrnico/Anagram.git
```

* _Install the .NET Framework_

  .NET Core 1.1 SDK (Software Development Kit)

  .NET runtime.

  See https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c for instructions and links.

* _Run the program_
  1. In the command line, cd into the project folder.
  2. In the command line, type dotnet restore. Enter.  It make take a few minutes to complete this process.
  3. In the command line, type dotnet build. Enter. Any errror messages will be displayed in red.  Errors will need to be corrected before the app can be run. After correcting errors and saving changes, type dotnet build again.  When message says Build succeeded in green, proceed to the next step.
  4. In the command line, type dotnet run. Enter.

* _View program on web browser at port localhost:5000/_

* _Enter a string into the form._

* _Enter a list into the form._

* _Submit the form to see the output._

## Support and contact details

_To suggest changes, submit a pull request in the GitHub repository._

## Technologies Used

* HTML
* C#
* .Net Core 1.1

### License

*MIT License*

Copyright (c) 2018 **_Nico Daunt_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
