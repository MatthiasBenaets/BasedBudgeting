import tkinter as tk
from tkinter import filedialog, Text
import os

root = tk.Tk()
root.attributes('-fullscreen', True)    # Attribute so app is fullscreen

col = ['#003241','#ffffff','#2d96af','#e6f5fa','#101010','#212121','#121212','#232323']
darkMode = 'Day'

# Check if there is a save and prints it if it exists
if os.path.isfile('save.txt'):
    with open('save.txt', 'r') as f:
        darkMode = f.read()

# Closes app
def quit():
    global root
    root.quit()

# Dark mode
def dark():
    global darkMode                           # Makes darkMode variable available
    if modeButton['text'] == 'Dark':
        navFrame.config(bg=col[4])
        budgetFrame.config(bg=col[5])
        accountFrame.config(bg=col[6])
        overallFrame.config(bg=col[7])
        modeButton['text'] = 'Light'
        darkMode = 'Night'
    elif modeButton['text'] == 'Light':
        navFrame.config(bg=col[0])
        budgetFrame.config(bg=col[1])
        accountFrame.config(bg=col[2])
        overallFrame.config(bg=col[3])
        modeButton['text'] = 'Dark'
        darkMode = 'Day'

# Canvas
canvas = tk.Canvas(root, bg='white')
canvas.pack(fill=tk.BOTH, expand=True)

# Top - Middle - Lef - Right Frame
if darkMode == "Day":
    navFrame = tk.Frame(root, bg=col[0])
    budgetFrame = tk.Frame(root, bg=col[1])
    accountFrame = tk.Frame(root, bg=col[2])
    overallFrame = tk.Frame(root, bg=col[3])
elif darkMode == "Night":
    navFrame = tk.Frame(root, bg=col[4])
    budgetFrame = tk.Frame(root, bg=col[5])
    accountFrame = tk.Frame(root, bg=col[6])
    overallFrame = tk.Frame(root, bg=col[7])
navFrame.place(relwidth=0.8, relheight=0.15, relx=0.2, rely=0)
budgetFrame.place(relwidth=0.55, relheight=0.85, relx=0.2, rely=0.15)
accountFrame.place(relwidth=0.2, relheight=1, relx=0, rely=0)
overallFrame.place(relwidth=0.25, relheight=0.85, relx=0.75, rely=0.15)

# Close button
closeButton = tk.Button(root, text="Quit", command=quit)
closeButton.place(relx=0.98, rely=0.01)

# Mode button
modeButton = tk.Button(root, text="Dark", command=dark)
modeButton.place(relx=0.95, rely=0.01)
if darkMode == "Day":
    modeButton['text'] = "Dark"
elif darkMode == "Night":
    modeButton['text'] = "Light"

# End mainloop
root.mainloop()

# Writing values to a file
with open('save.txt', 'w') as f:
    f.write(darkMode)