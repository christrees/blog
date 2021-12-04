# Learn vim

## Movement

- Character Line
    ```
           ↑
     ← h j k l →
         ↓
    ```
- Word
  - `w` or `W` -> word or WORD forward
  - `b` or `B` -> word or WORD backward
  - `e` or `E` -> end of word or WORD forward
  - `ge` or `gE` -> end of word or WORD backward
- Find
  - `f{character}` (find) to move to the next occurrence of a character in a line.
  - `F{character}` to find the previous occurrence of a character
  - `t{character}` to move the cursor just before the next occurrence of a character 
  - `T{character}` to do the same as `t{character}` but backwards
  - `;` to go to the next occurrence of the character or `,` to go to the previous one.
- Horizontally
  - `0` Moves to the first character of a line
  - `^` Moves to the first non-blank character of a line
  - `$` Moves to the end of a line
  - `g_` Moves to the non-blank character at the end of a line
- Vertically
  - `}` jumps entire paragraphs downwards
  - `{` similarly but upwards
  - `CTRL-D` lets you move down half a page by scrolling the page
  - `CTRL-U` lets you move up half a page also by scrolling
- Pattern
  - `/{pattern}` to search forward
  - `?{pattern}` to search backwards
  - `n` to go to the next match
  - `N` to go to the previous match
- Core
  - `gg` to go to the top of the file.
  - `{line}gg` to go to a specific line.
  - `G` to go to the end of the file.
  - `%` jump to matching `({[]})`.

## Operators

You use **operators** in combination with **counts** and **motions** to define the range of text to which an action applies:

```
   what to do (delete, change...)
      /
     /      how many times
    /         /
   v         v
{operator}{count}{motion}
                    ^
                   /
                  /
           where to perform
             the action
```
- Examples
    - `d2w` to **d**elete **2** **w**ords.
    - `u` to undo
    - `<CTRL-R>` to redo

---
---

## VIM Trink config notes

- Using [Visual Studio Code](https://code.visualstudio.com/)
  - Vim emulation by vscodevim
  - Learn Vim by vintharas
- VSCode Settings /Users/cat/Library/Application Support/Code/User/settings.json
  - Editor : Line Numbers -> realitive
  - Editor : minimap -> false
    ```json
    {
        "editor.lineNumbers": "relative",
        "editor.minimap.enabled": false
    }
    ```
- See which shell 
    - zsh
    ```zsh
    (base) cat@cats-Mac-mini ~ % echo $0
    /bin/zsh
    ```
    - bash
    ```bash
    (base) cats-Mac-mini:~ cat$ echo $0
    /bin/bash
    ```
- Trink inputrc in home dir
    ```bash
    ### .inputrc
        - set show-mode-in-prompt on
        - set vi-cmd-mode-string "\1\e[2 q\2"
        - set vi-ins-mode-string "\1\e[6 q\2"
    ```
- tbd
- tbd

