import tkinter as tk
from tkinter.font import BOLD
from datetime import date

LARGE_FONT= ("Calibri", 12)                                                                                     # Font Variable
col = ['#003241','#ffffff','#2d96af','#e6f5fa','#ffffff']                                                       # Color pallette (for dark mode)
dim = [0.12,0.2,0.25,0.8]                                                                                       # Frame Dimensions
dim2 = [0.06]   

today = date.today()                                                                                            # Date for navigation
currentDate = today.strftime("%b %Y").upper()

class App(tk.Tk):                                                                                               # Main class, load on start

    def __init__(self, *args, **kwargs):
        tk.Tk.__init__(self, *args, **kwargs)

        tk.Tk.iconbitmap(self, default="src/Budget.ico")                                                        # App icon
        tk.Tk.wm_title(self, "Based Budgetting")                                                                # App title
        self.attributes('-fullscreen', True)                                                                    # Fullscreen mode

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

        closeButton = tk.Button(frame, text="Quit", command=quit)                                               # Close Button
        closeButton.place(relx=0.98, rely=0.01)

    def menu(self):                                                                                             # Menu needs to be loaded on every frame
        accBudget = tk.Frame(self, bg=col[2])
        accBudget.place(relwidth=1-dim[3], relheight=1, relx=0, rely=0)                                         # Place items

        self.budgetBtn = tk.Button(self, text="Budget", font=("Calibi", 15, BOLD), anchor='w',
                                          bg=col[0], fg=col[4],
                                          activebackground=col[3], activeforeground=col[0],
                                          highlightthickness = 0, bd = 0,
                                          command=lambda: [self.show_frame(Budget), self.nav1()])               # Nav Button
        self.reportsBtn = tk.Button(self, text="Reports", font=("Calibi", 15, BOLD), anchor='w',
                                         bg=col[2], fg=col[4],
                                         highlightthickness = 0, bd = 0,
                                         command=lambda: [self.show_frame(Reports), self.nav2()])               # Nav Button
        self.allAccBtn = tk.Button(self, text="All Accounts", font=("Calibi", 15, BOLD), anchor='w',
                                         bg=col[2], fg=col[4],
                                         highlightthickness = 0, bd = 0,
                                         command=lambda: [self.show_frame(Accounts), self.nav3()])              # Nav Button
        self.bla1="2"

        self.budgetBtn.place(relx=0, rely=dim[0], relwidth=dim[1], relheight=dim2[0])                           # Place Nav Buttons
        self.reportsBtn.place(relx=0, rely=dim[0]+dim2[0], relwidth=dim[1], relheight=dim2[0])
        self.allAccBtn.place(relx=0, rely=dim[0]+2*dim2[0], relwidth=dim[1], relheight=dim2[0])

        titleBudget = tk.Label(accBudget, text="My Budget", bg=col[2], fg=col[4], font=("Calibi", 35, BOLD))    # Title
        titleBudget.place(relwidth=1, relheight=dim[0], relx=0, rely=0)

    def nav1(self):                                                                                             # Change background of active frame navigation button
        self.budgetBtn.config(bg=col[0])
        self.reportsBtn.config(bg=col[2])
        self.allAccBtn.config(bg=col[2])

    def nav2(self):                                                                                             # Change background of active frame navigation button
        self.budgetBtn.config(bg=col[2])
        self.reportsBtn.config(bg=col[0])
        self.allAccBtn.config(bg=col[2])

    def nav3(self):                                                                                             # Change background of active frame navigation button
        self.budgetBtn.config(bg=col[2])
        self.reportsBtn.config(bg=col[2])
        self.allAccBtn.config(bg=col[0])

    def quit(self):                                                                                             # Close app
        App.quit()

class Budget(tk.Frame):                                                                                         # Budget frame

    def __init__(self, parent, controller):
        tk.Frame.__init__(self, parent)

        navBudget = tk.Frame(self, bg=col[0])                                                                   # Frame items            
        catBudget = tk.Frame(self, bg=col[1])
        allBudget = tk.Frame(self, bg=col[3])
        navBudget.place(relwidth=dim[3], relheight=dim[0], relx=1-dim[3], rely=0)                               # Place items
        catBudget.place(relwidth=1-dim[1]-dim[2], relheight=1-dim[0], relx=1-dim[3], rely=dim[0])
        allBudget.place(relwidth=dim[2], relheight=1-dim[0], relx=1-dim[2], rely=dim[0])

        #Content in top frame
        dateBudget = tk.Label(navBudget, text=currentDate, bg=col[0], fg=col[4], font=("Calibi", 35, BOLD))     # Date
        dateBudget.place(relwidth=0.5, relheight=1, relx=0, rely=0)
        
class Reports(tk.Frame):                                                                                        # Reports frame

    def __init__(self, parent, controller):
        tk.Frame.__init__(self, parent)

        navReports = tk.Frame(self, bg=col[0])                                                                  # Frame items
        catReports = tk.Frame(self, bg=col[1])
        allReports = tk.Frame(self, bg=col[3])
        navReports.place(relwidth=dim[3], relheight=dim[0], relx=1-dim[3], rely=0)                              # Place items
        catReports.place(relwidth=1-dim[1]-dim[2], relheight=1-dim[0], relx=1-dim[3], rely=dim[0])
        allReports.place(relwidth=dim[2], relheight=1-dim[0], relx=1-dim[2], rely=dim[0])

class Accounts(tk.Frame):

    def __init__(self, parent, controller):
        tk.Frame.__init__(self, parent)

        navAccounts = tk.Frame(self, bg=col[0])                                                                 # Frame items
        catAccounts = tk.Frame(self, bg=col[1])
        accAccounts = tk.Frame(self, bg=col[2])
        navAccounts.place(relwidth=dim[3], relheight=dim[0], relx=1-dim[3], rely=0)                             # Place items
        catAccounts.place(relwidth=1-dim[1], relheight=1-dim[0], relx=1-dim[3], rely=dim[0])
        accAccounts.place(relwidth=1-dim[3], relheight=1, relx=0, rely=0)

app = App()                                                                                                     # Run main loop on execution
app.mainloop()