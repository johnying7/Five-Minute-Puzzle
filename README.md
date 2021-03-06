# Five-Minute-Puzzle

Five Minute Puzzle Collaboration Game to learn the process for developing games.

# Project Set Up

## Unity3D

```
Unity Version: 2019.2.17f1
```

## Visual Studio Code

The recommended text editor is Visual Studio Code found [here](https://code.visualstudio.com/).
Go [here](https://code.visualstudio.com/docs/other/unity) attach VSCode with unity.

For installation, the default settings or any personal preferences will work for the project.

With VS Code open, Ctrl+Shift+G to open the source control tab and make sure that the repository has been attached, initialized, and connected to the github repository.

For plug-in installation, in VSCode do Ctrl-Shift-X(Windows) or Cmd-Shift-X(MacOS)
Recommended Programming extensions:
```
C# - by Microsoft
C# XML Documentation Comments - by Keisuke Kato
Debugger for Unity - by Unity Technologies
Unity Code Snippets - by Kleber Silva
Unity Tools - by Tobiah Zarlez
```

You do **NOT** need to change file exclusions or download the .NET Framework 4.6 Targeting Pack.

## Git For Windows

Download [Git for Windows](https://gitforwindows.org/).

* Run the executable
* Uncheck "Only Show New Options" if it is available in Configuring the line endings section.
* Click ``Next`` -> ``Next`` to approve the license and default components
* Use Visual Studio as Git's default editor (ensure you already have visual studio code installed first)
* Git from the command line and also from 3rd-Party Software
* Use the Open-SSL library
* Checkout Windows-style, commit Unix-style line endings
* Use MinTTY (the default terminal of MSYS2)
* Make sure you're using these options:
  * Enable file system caching
  * Enable Git Credential Manager
* Do **NOT** use experimental build
* Click Install

* Open File Explorer in the directory (example C:\Users\John) you want your project and then Right-Click -> Git Bash Here and type:
  ```
  $ git config --global user.name "Your name here"
  $ git config --global user.email "your_email@example.com"
  $ git clone https://github.com/johnying7/Five-Minute-Puzzle.git
  ```

Normally, to work with changes to the repository, you will need to login each time with your github credentials. You can use this SSH [guide](https://help.github.com/en/github/authenticating-to-github/connecting-to-github-with-ssh) to skip the process by saving your security key.

## Git LFS

https://help.github.com/en/github/managing-large-files/configuring-git-large-file-storage
LFS storage size is currently the default total of 1GB.

To check which files will be lfs files (common for imported packages)
``git lfs ls-files``

You will need [Git LFS](https://git-lfs.github.com/) (Large File Support) installed for storing large files such as images and 3D models in github efficiently. It will manage the files based on the ``.gitattributes`` file.

[Reference](https://thoughtbot.com/blog/how-to-git-with-unity)

After installing
* open git bash shell in project directory (example C:\Users\John\Five-Minute-Puzzle)
* run ``git lfs install``

# Github Process

**Creating a New Issue**
* Use the preconfigured template to create a new issue
* Follow and fill out the template
* If there are not any prerequisite requirements, put N/A
* Add correct associations on the right hand side
  * Assignees (Yourself)
  * [Optional] Labels
  * Project
  * Milestone

**Creating a New Branch**
* Do not start new branch if prerequisite issues are not finished
* Branch name should be ISSUE-XX: ``ISSUE-5`` where XX is the issue number
  ```
  git checkout master
  git pull origin master
  git checkout -b ISSUE-XX
  ```
* Begin making your changes to the project
* You may commit your changes as many times as you want, but be sure to rebase later

**Making a Pull Request**
  
* After making the changes to your branch, you need to commit (save them) locally using the Visual Studio Code Source Control tab (Ctrl+Shift+G)
* Once on the tab, ``Stage All Changes`` and set the commit message in the format:
  * ``Resolves #XX Issue Title``
  * Example: ``Resolves #1 Initial Online Functionality``
* Click the Commit checkmark
* If you have made more than one new commit, do the next git steps, otherwise skip to git push step after Save and Close
    ```
    git checkout master
    git pull origin master
    git checkout ISSUE-XX
    git rebase -i origin/master
    ```
  * Leave the first commit as ``pick``
  * Set every commit after the first pick as ``squash``
  * Save and Close
  * Comment out the other commit messages except for the one required with a # before the commit message
  * Save and Close
  ```
  git push --set-upstream origin ISSUE-XX
  ```
* Create a pull request to set to in-progress with the same title as the associated issue on the github website
* In pull request details, include: ``Resolves #XX Issue Title``
* Add correct associations on the right hand side
  * Assignees
  * [Optional] Labels
  * Project
  * Milestone

**Pull Request Complete**
* Double check above associations are present
  * Add appropriate reviewers
  * Have reviewers verify your changes
* Before being approved, ``git push`` your changes.
* Make sure the pull request has been approved with all changes
  ```
  git checkout master
  git pull origin master
  git checkout ISSUE-XX
  git rebase -i origin/master
  ```
* Leave the first commit as ``pick``
* Set every commit after the first pick as ``squash``
* Save and Close
* Comment out the other commit messages except for the one required with a # before the commit message
* Save and Close
  ```
  git push origin ISSUE-XX --force
  git checkout master
  git merge ISSUE-XX
  git push origin master
  git branch -d ISSUE-XX
  ```
* Go to the pull request in github and delete the branch

## Additional Git Notes

Setting the upstream is only required once. Afterward, you may simply use ``git push``. If you rebase and need to apply your changes, use ``git push origin ISSUE-XX --force``.

To open Git Bash in your project, you can open file explorer at the project file location (example C:\Users\John\Five-Minute-Puzzle), Right-Click -> Git Bash Here.

To set the upstream of the local branch to the remote branch (local-branch and remote-branch is the name of the branch you want to link ie. 'master' or 'stable')
```
git checkout <local-branch>
git branch --set-upstream-to <remote-branch>
```
### Example
```
git checkout playerLoot
git branch --set-upstream-to playerLoot
```

# Some extra MD documentation references
Here would be the set up details for starting the project.

[Here is a link to google](https://www.google.com)

> Here is a side note
> that should be displayed in a new specialized box.

``Here would be a line that should be highlighted``

**Here is some bolded text**

* Bullet 1
* Bullet 2

## A subcategory of project set up