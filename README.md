﻿# Rewriting Git History

This repository is used in my Rewriting Git History to Supercharge Your Code Reviews talk. Feel free to peruse the branches and play with the code to practice rewriting Git history!

### You'll need to AutoSquash

Many of the examples i'll be demoning will be squashing commits together. In order to do that, the --autosquash parameter needs to be passed to the rebase command. Rather than doing this every time, I have set a global setting to always autosquash during rebases. If you'd like to do that too the command is

`git config --global rebase.autosquash true`

### Some Aliases you'll see

I like aliases. I like aliases a lot. In this demo, I won't use many of them, but there are a couple I will. These are down below. Feel free to use them if you like them.

#### new 
Gets the commits since last merge to main in one line and reverse order (if your repo uses master instead of main, change main to master in the line below)
 
 `git config --global alias.new 'log --oneline --reverse main..'`

#### rbc
Alias for git rebase --continue

`git config --global alias.rbc 'rebase --continue'`

#### rba
Alias for git rebase --abort

`git config --global alias.rba 'rebase --abort'`

### Tech I'll be Using

During this demo I'll be using the following technology. You don't have to use these technologies, but they're currently my preferred tools
- PoshGit
- C# in Visual Studio
- Diff/Merge tool: Beyond Compare
- Editor: VSCode
