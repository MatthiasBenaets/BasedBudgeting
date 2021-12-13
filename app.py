import tkinter as tk                                                                                            # Imports
from tkinter.font import BOLD, ITALIC
from tkinter import *
from datetime import date

col = ['#003241','#ffffff','#2d96af','#e6f5fa','#005a78','#d3d3d3']                                             # Color pallette (for dark mode)
dim = [.12,.2,.25,.8]                                                                                           # Frame Dimensions
dimObj = [.003,.08,.14]                                                                                         # Dimension of nested frames, labels, etc..

today = date.today()                                                                                            # Date for navigation
currentDate = today.strftime("%b %Y").upper()

class App(tk.Tk):                                                                                               # Main class, load on start

    def __init__(self, *args, **kwargs):
        tk.Tk.__init__(self, *args, **kwargs)

        tk.Tk.iconbitmap(self, default="src/Budget.ico")                                                        # App icon
        tk.Tk.wm_title(self, "Based Budgetting")                                                                # App title
        self.attributes('-fullscreen', True)                                                                   # Fullscreen mode

        container = tk.Frame(self)                                                                              # Container that is scalable (when no fullscreen)
        container.pack(side="top", fill="both", expand = True)
        container.grid_rowconfigure(0, weight=1)
        container.grid_columnconfigure(0, weight=1)

        self.frames = {}                                                                                        # Contains all frames

        for F in (Budget, Reports, Accounts):                                                                   # Loop to show correct frame (window)
            frame = F(container, self)
            self.frames[F] = frame
            frame.grid(row=0, column=0, sticky="nsew")

        self.show_frame(Budget)

    def show_frame(self, cont):                                                                                 # Function to show correct frame and bring permanent items over

        frame = self.frames[cont]                                                                               # Frame is what conroller reports
        frame.tkraise()                                                                                         # Raise correct frame to front

        self.menu()                                                                                             # Run menu function

        closeButton = tk.Button(frame, text="X", command=quit)                                                  # Close Button
        closeButton.place(relx=0.985, rely=0.01)

    def menu(self):                                                                                             # Menu needs to be loaded on every frame
        mainMenu = tk.Frame(self, bg=col[2])
        mainMenu.place(relwidth=1-dim[3], relheight=.88, relx=0, rely=.12)                                      # Place items
        
        canvas = tk.Canvas(mainMenu, bg=col[2], highlightthickness=0)                                           # Canvas needed to draw lines
        canvas.create_line(0, 1, 1000, 1, fill=col[4], width=5)
        canvas.place(relx = 0, rely = 3*dimObj[1], relheight = 0.01, relwidth = 1)
        
        self.budgetBtn = tk.Button(mainMenu, text="Budget", font=("Calibi", 15, BOLD), anchor='w',
                                   bg=col[4], fg=col[1],
                                   activebackground=col[3], activeforeground=col[4],
                                   highlightthickness = 0, bd = 0,
                                   command=lambda: [self.show_frame(Budget), self.nav1()])                      # Nav Button
        self.reportsBtn = tk.Button(mainMenu, text="Reports", font=("Calibi", 15, BOLD), anchor='w',
                                    bg=col[2], fg=col[1],
                                    activebackground=col[3], activeforeground=col[4],
                                    highlightthickness = 0, bd = 0,
                                    command=lambda: [self.show_frame(Reports), self.nav2()])                    # Nav Button
        self.allAccBtn = tk.Button(mainMenu, text="All Accounts", font=("Calibi", 15, BOLD), anchor='w',
                                   bg=col[2], fg=col[1],
                                   activebackground=col[3], activeforeground=col[4],
                                   highlightthickness = 0, bd = 0,
                                   command=lambda: [self.show_frame(Accounts), self.nav3()])                    # Nav Button

        self.budgetBtn.place(relx=0, rely=0, relwidth=1, relheight=dimObj[1])                                   # Place Nav Buttons
        self.reportsBtn.place(relx=0, rely=dimObj[1], relwidth=1, relheight=dimObj[1])
        self.allAccBtn.place(relx=0, rely=2*dimObj[1], relwidth=1, relheight=dimObj[1])

    def nav1(self):                                                                                             # Change background of active frame navigation button
        self.budgetBtn.config(bg=col[4])
        self.reportsBtn.config(bg=col[2])
        self.allAccBtn.config(bg=col[2])

    def nav2(self):                                                                                             # Change background of active frame navigation button
        self.budgetBtn.config(bg=col[2])
        self.reportsBtn.config(bg=col[4])
        self.allAccBtn.config(bg=col[2])

    def nav3(self):                                                                                             # Change background of active frame navigation button
        self.budgetBtn.config(bg=col[2])
        self.reportsBtn.config(bg=col[2])
        self.allAccBtn.config(bg=col[4])

    def quit(self):                                                                                             # Close app
        App.quit()

class Budget(tk.Frame):                                                                                         # Budget frame

    def __init__(self, parent, controller):
        tk.Frame.__init__(self, parent)

        titleBudget = tk.Label(self, text="My Budget", bg=col[2], fg=col[1], font=("Calibi", 35, BOLD))         # Title
        titleBudget.place(relwidth=1-dim[3], relheight=dim[0], relx=0, rely=0)

        navBudget = tk.Frame(self, bg=col[0])                                                                   # Frame items            
        catBudget = tk.Frame(self, bg=col[1])
        allBudget = tk.Frame(self, bg=col[3])
        navBudget.place(relwidth=dim[3], relheight=dim[0], relx=1-dim[3], rely=0)                               # Place items
        catBudget.place(relwidth=1-dim[1]-dim[2], relheight=1-dim[0], relx=1-dim[3], rely=dim[0])
        allBudget.place(relwidth=dim[2], relheight=1-dim[0], relx=1-dim[2], rely=dim[0])

        dateBudget = tk.Label(navBudget, text=currentDate, bg=col[0], fg=col[1], font=("Calibi", 35, BOLD))     # Date
        dateBudget.place(relwidth=0.5, relheight=1, relx=0, rely=0)

        Budgeted = tk.Frame(allBudget, bg=col[3])                                                               # Frames, Labels and separators for allBudget
        Activity = tk.Frame(allBudget, bg=col[3])
        Available = tk.Frame(allBudget, bg=col[3])
        Inflow = tk.Frame(allBudget, bg=col[3])
        lbl1Budgeted = tk.Label(Budgeted, text="TOTAL BUDGETTED", bg=col[3], fg=col[4], font=("Calibi", 15, BOLD))
        lbl1Activity = tk.Label(Activity, text="TOTAL ACTIVITY", bg=col[3], fg=col[4], font=("Calibi", 15, BOLD))
        lbl1Available = tk.Label(Available, text="TOTAL AVAILABLE", bg=col[3], fg=col[4], font=("Calibi", 15, BOLD))
        lbl1Inflow = tk.Label(Inflow, text="TOTAL INFLOW", bg=col[3], fg=col[4], font=("Calibi", 15, BOLD))
        Sep1 = tk.Frame(allBudget, bg=col[5])
        Sep2 = tk.Frame(allBudget, bg=col[5])
        Sep3 = tk.Frame(allBudget, bg=col[5])
        Sep4 = tk.Frame(allBudget, bg=col[5])
        Budgeted.place(relwidth=1, relheight=dimObj[2], relx=0, rely=0)
        Activity.place(relwidth=1, relheight=dimObj[2], relx=0, rely=dimObj[2])
        Available.place(relwidth=1, relheight=dimObj[2], relx=0, rely=2*dimObj[2])
        Inflow.place(relwidth=1, relheight= dimObj[2], relx=0, rely=3*dimObj[2])
        lbl1Budgeted.place(relwidth=1, relheight=0.5, relx=0, rely=0)
        lbl1Activity.place(relwidth=1, relheight=0.5, relx=0, rely=0)
        lbl1Available.place(relwidth=1, relheight=0.5, relx=0, rely=0)
        lbl1Inflow.place(relwidth=1, relheight= 0.5, relx=0, rely=0)
        Sep1.place(relwidth=0.6, relheight=dimObj[0], relx=0.2, rely=dimObj[2])
        Sep2.place(relwidth=0.6, relheight=dimObj[0], relx=0.2, rely=2*dimObj[2])
        Sep3.place(relwidth=0.6, relheight=dimObj[0], relx=0.2, rely=3*dimObj[2])
        Sep4.place(relwidth=0.6, relheight=dimObj[0], relx=0.2, rely=4*dimObj[2])

        self.image = PhotoImage(file="src/arrow.png")                                                           # Arrow for available budget
        label = tk.Label(navBudget, image=self.image, bg=col[0])
        label.place(relwidth=0.2, relheight=1, relx=0.4, rely=0)

class Reports(tk.Frame):                                                                                        # Reports frame

    def __init__(self, parent, controller):
        tk.Frame.__init__(self, parent)

        titleReports = tk.Label(self, text="My Reports", bg=col[2], fg=col[1], font=("Calibi", 35, BOLD))       # Title
        titleReports.place(relwidth=1-dim[3], relheight=dim[0], relx=0, rely=0)

        navReports = tk.Frame(self, bg=col[0])                                                                  # Frame items
        catReports = tk.Frame(self, bg=col[1])
        allReports = tk.Frame(self, bg=col[3])
        navReports.place(relwidth=dim[3], relheight=dim[0], relx=1-dim[3], rely=0)                              # Place items
        catReports.place(relwidth=1-dim[1]-dim[2], relheight=1-dim[0], relx=1-dim[3], rely=dim[0])
        allReports.place(relwidth=dim[2], relheight=1-dim[0], relx=1-dim[2], rely=dim[0])

        Month = tk.Frame(allReports, bg=col[3])                                                                 # Frames, labels and separators for allReports
        Budgeted = tk.Frame(allReports, bg=col[3])
        Spending = tk.Frame(allReports, bg=col[3])
        lbl1Month = tk.Label(Month, text=currentDate, bg=col[3], fg=col[4], font=("Calibi", 25, BOLD)) 
        lbl2Month = tk.Label(Month, text="All categories and accounts included", bg=col[3], fg=col[4], font=("Calibi", 12, ITALIC))
        lbl1Budgeted = tk.Label(Budgeted, text="TOTAL SPENDING", bg=col[3], fg=col[4], font=("Calibi", 12))
        lbl2Budgeted = tk.Label(Budgeted, text="for this time periode", bg=col[3], fg=col[4], font=("Calibi", 12, ITALIC))
        lbl1Spending = tk.Label(Spending, text="AVERAGE SPENDING", bg=col[3], fg=col[4], font=("Calibi", 12))
        lbl2Spending = tk.Label(Spending, text="Per month (of the last 12 months)", bg=col[3], fg=col[4], font=("Calibi", 12, ITALIC))
        Sep1 = tk.Frame(allReports, bg=col[5])
        Sep2 = tk.Frame(allReports, bg=col[5])
        Sep3 = tk.Frame(allReports, bg=col[5])
        Month.place(relwidth=1, relheight=dimObj[2], relx=0, rely=0)
        Budgeted.place(relwidth=1, relheight=dimObj[2], relx=0, rely=dimObj[2])
        Spending.place(relwidth=1, relheight=dimObj[2], relx=0, rely=2*dimObj[2])
        lbl1Month.place(relwidth=1, relheight=0.333, relx=0, rely=0.333)
        lbl2Month.place(relwidth=1, relheight=0.333, relx=0, rely=0.666)
        lbl1Budgeted.place(relwidth=1, relheight=0.333, relx=0, rely=0)
        lbl2Budgeted.place(relwidth=1, relheight=0.333, relx=0, rely=0.666)
        lbl1Spending.place(relwidth=1, relheight=0.333, relx=0, rely=0)
        lbl2Spending.place(relwidth=1, relheight=0.333, relx=0, rely=0.666)
        Sep1.place(relwidth=0.6, relheight=dimObj[0], relx=0.2, rely=dimObj[2])
        Sep2.place(relwidth=0.6, relheight=dimObj[0], relx=0.2, rely=2*dimObj[2])
        Sep3.place(relwidth=0.6, relheight=dimObj[0], relx=0.2, rely=3*dimObj[2])

class Accounts(tk.Frame):

    def __init__(self, parent, controller):
        tk.Frame.__init__(self, parent)

        titleAccounts = tk.Label(self, text="My accounts", bg=col[2], fg=col[1], font=("Calibi", 35, BOLD))     # Title
        titleAccounts.place(relwidth=1-dim[3], relheight=dim[0], relx=0, rely=0)

        navAccounts = tk.Frame(self, bg=col[0])                                                                 # Frame items
        catAccounts = tk.Frame(self, bg=col[1])
        navAccounts.place(relwidth=dim[3], relheight=dim[0], relx=1-dim[3], rely=0)                             # Place items
        catAccounts.place(relwidth=1-dim[1], relheight=1-dim[0], relx=1-dim[3], rely=dim[0])

app = App()                                                                                                     # Run main loop on execution
app.mainloop()