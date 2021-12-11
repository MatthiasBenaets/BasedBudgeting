import tkinter as tk
from tkinter import Frame, Label, filedialog, Text
from tkinter.font import BOLD
from datetime import date
import os

root = tk.Tk()
root.attributes('-fullscreen', True)                                    # Attribute so app is fullscreen
#root.state('zoomed')                                                    # Make window scalable
root.rowconfigure(0, weight=1)
root.columnconfigure(0, weight=1)

col = []                                                                # Color pallette (for dark mode)
day = ['#003241','#ffffff','#2d96af','#e6f5fa','#ffffff']
night = ['#101010','#212121','#121212','#232323','#ffffff']
darkMode = 'Day'

dim = [0.12,0.2,0.25,0.8]                                               # Dimension for easy changes

today = date.today()                                                    # Date for navigation
currentDate = today.strftime("%b %Y").upper()

# Show correct frame an move over everything simular to visible frame
def show_frame(frame):    
    frame.tkraise()                                                     # Make correct frame visible
    closeButton = tk.Button(frame, text="Quit", command=quit)           # Close Button
    closeButton.place(relx=0.98, rely=0.01)
        

# Check if there is a save and prints it if it exists
if os.path.isfile('save.txt'):
    with open('save.txt', 'r') as f:
        darkMode = f.read()
        if darkMode == 'Day':
            col = day
        elif darkMode == 'Night':
            col = night
else:
    col = day

# Closes app
def quit():
    global root
    root.quit()

#Dark mode
def dark():
    global darkMode                                                     # Makes darkMode variable available
    if modeButton['text'] == 'Dark':                                    # Change button text to other option
        modeButton['text'] = 'Light'
        darkMode = 'Night'
        col = night
    elif modeButton['text'] == 'Light':
        modeButton['text'] = 'Dark'
        darkMode = 'Day'
        col = day
    navFrame.config(bg=col[0])                                          # Change color to current pallet
    budgetFrame.config(bg=col[1])
    accountFrame.config(bg=col[2])
    overallFrame.config(bg=col[3])

    for widget in accountFrame.winfo_children():                        # Change background color of labels
        if isinstance(widget, Label):
            widget.config(bg=col[2], fg=col[4])
    for widget in navFrame.winfo_children():
        if isinstance(widget, Label):
            widget.config(bg=col[0], fg=col[4])

# Frames
frame1 = tk.Frame(root)                                                 # List of all frames
frame2 = tk.Frame(root)
frame3 = tk.Frame(root)
#canvas.pack(fill=tk.BOTH, expand=True)
for frame in (frame1, frame2, frame3):                                  # Loop to place correct frame
    frame.grid(row=0, column=0, sticky='nsew')

#================================================================ Frame 1

# Top - Middle - Left - Right Frame
navFrame = tk.Frame(frame1, bg=col[0])
budgetFrame = tk.Frame(frame1, bg=col[1])
accountFrame = tk.Frame(frame1, bg=col[2])
overallFrame = tk.Frame(frame1, bg=col[3])
navFrame.place(relwidth=dim[3], relheight=dim[0], relx=1-dim[3], rely=0)
budgetFrame.place(relwidth=1-dim[1]-dim[2], relheight=1-dim[0], relx=1-dim[3], rely=dim[0])
accountFrame.place(relwidth=1-dim[3], relheight=1, relx=0, rely=0)
overallFrame.place(relwidth=dim[2], relheight=1-dim[0], relx=1-dim[2], rely=dim[0])

# Dark Mode
modeButton = tk.Button(frame1, text="Dark", command=dark)            # Mode Button
modeButton.place(relx=0.95, rely=0.01)
if darkMode == 'Night':
    print('true')
    modeButton['text'] = 'Light'

# Content in left frame
label = tk.Label(accountFrame, text="My Budget", bg=col[2], fg=col[4], font=("Calibi", 35, BOLD))
label.place(relwidth=1, relheight=dim[0], relx=0, rely=0)

frame1_btn = tk.Button(accountFrame, text="Reports", bg=col[2], fg=col[4], font=("Calibi", 25, BOLD), command=lambda:show_frame(frame2))
frame1_btn.place(relx=0, rely=0.13)

# Content in top frame
label = tk.Label(navFrame, text=currentDate, bg=col[0], fg=col[4], font=("Calibi", 35, BOLD))
label.place(relwidth=0.5, relheight=1, relx=0, rely=0)

show_frame(frame1)

#================================================================ Frame 2
# Top - Middle - Left - Right Frame
navFrame2 = tk.Frame(frame2, bg=col[0])
budgetFrame2 = tk.Frame(frame2, bg=col[1])
accountFrame2 = tk.Frame(frame2, bg=col[2])
overallFrame2 = tk.Frame(frame2, bg=col[3])
navFrame2.place(relwidth=dim[3], relheight=dim[0], relx=1-dim[3], rely=0)
budgetFrame2.place(relwidth=1-dim[1]-dim[2], relheight=1-dim[0], relx=1-dim[3], rely=dim[0])
accountFrame2.place(relwidth=1-dim[3], relheight=1, relx=0, rely=0)
overallFrame2.place(relwidth=dim[2], relheight=1-dim[0], relx=1-dim[2], rely=dim[0])
# Content in left frame
label = tk.Label(accountFrame2, text="Reports", bg=col[2], fg=col[4], font=("Calibi", 35, BOLD))
label.place(relwidth=1, relheight=dim[0], relx=0, rely=0)
frame1_btn = tk.Button(accountFrame2, text="Budget", bg=col[2], fg=col[4], font=("Calibi", 25, BOLD), command=lambda:show_frame(frame1))
frame1_btn.place(relx=0, rely=0.13)

# End mainloop (startup)
root.mainloop()

# Writing values to a file
with open('save.txt', 'w') as f:
    f.write(darkMode)