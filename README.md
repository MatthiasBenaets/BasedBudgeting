<h1 align="center">
  <br>
  <a href=""><img src="basedbudgeting.png" alt="Based Budgeting" width="500"></a>
  <br>
</h1>
<div align="center">
<h3><b><u>BASED BUDGETING </u><br>
💰📈 GENERAL HANDBOOK 📊💵 </b></h3>
  <h3>
    <a href="https://github.com/MatthiasBenaets/BasedBudgeting/blob/master/LICENSE">
      License
    </a>
    <span> · </span>
    <a href="https://github.com/matthiasbenaets/basedbudgeting/releases/">
      Download
    </a>
    <span> · </span>
    <a href="https://github.com/matthiasbenaets/basedbudgeting/issues">
      Issues
    </a>
    <span> · </span>
    <a href="https://matthiasbenaets.github.io/">
      Contact
    </a>
  </h3>
  <h1></h1>
</div>

<div align="center">Based Budgeting is a budgeting application written in Visual Basic .NET for Windows.

The applications aims to make you get a hold of your personal finances and set limits on expenses, all while growing your net worth and purchase power.

Either take the blue pill and live in ignorance and debt, or take the red pill and discover potential financial growth and become debt free.
</div>

##  📋Table of Contents
- [🏷️Features](#%EF%B8%8Ffeatures)
- [🕹️Usage](#%EF%B8%8Fusage)
- [🧩Components](#components)
- [⌛Download](#download)
- [🙋FAQ](#faq)
- [👋Contact](#contact)
<br></br>
<img src="src\README\Budget.png" alt="Based Budgeting" width="49%"></img>
<img src="src\README\Spending.png" alt="Based Budgeting" width="49%"></img>
<br></br>

##  🏷️Features
- **Give Your Money A Job**: With Multi-Category Budgeting, split transaction in multiple (sub-)categories.
- **Visualise balance**: Visual representation of transactions and net worth.
- **Transaction Tracker**: Log all inflow and outflow of your accounts.
- **Keeping track of the past**: All monthly budgets and bank balances will be stored for reference in the future.
- **User Friendly**: Aimed to make the process as much of as possible automated.
- **Stocks Logger**: Coming soon™
<br></br>
##  🕹️Usage
<br>
<img src="src\README\BudgetGuide.png" alt="Budget Menu" width="97%"></img>

### **Guide Legend**
1. Add an account and its balance to your budget. It's quite important that you use the correct decimal separator (eg. period vs comma).
2. Add a category to you budget. When it is created, you can add subcategories.
3. There will always be a free row available for every cateogory to add subcategories.
4. Cells to select a specific row in the datagrid. To delete the row, use your delete key.
5. Budget in an amount for the various subcategories. Only number with the correct decimal separator get accepted.
6. Your available balance that still needs to be budgeted.
7. When a new month is started, activities will get reset and the budget gets stored. Via the arrow you can navigate in time.
8. Navigation buttons. These will become available when enough information is added to the budget.
9. Available space to add personal notes about your budget.
10. Navigation buttons for Reports tab.
11. Save transactions.
12. Filter to search in transactions. Due to some limitations, if you want to filter by multiple items, filter by date first. You can filter by: Account / Date / Payee / Category/ Subcategory / Memo

<img src="src\README\Report1Guide.png" alt="Based Budgeting" width="48%"></img>
<img src="src\README\Report3Guide.png" alt="Based Budgeting" width="48%"></img>
<img src="src\README\Report2Guide.png" alt="Based Budgeting" width="48%"></img>
<img src="src\README\NotesGuide.png" alt="Based Budgeting" width="48%"></img>
<img src="src\README\TransactionsGuide.png" alt="Based Budgeting" width="97%"></img>
<br></br>

##  🧩Components
- **Accounts:**
    - Add multiple bank accounts to the budget.
    - Keep track of bank accounts, cash or even your investment portfolio balance at one place.
    - Balance will stay updated and calculated automatically after initial setup.
- **Budget:**
    - Keep a budget for the current month and review budget from previous months.
    - List different categories and subcategories.
        - Budget available money from your budget.
        - Review monthly activity of the different categories.
        - Follow up on the available balance of your budgeted categories.
    - Always be on top of how much you budgeted, your inflow & outflow and overall availablity of the current month.
- **Reports:**
    - Net worth chart: Visualise money diversification.
    - Current month doughnut spending chart: link to your subcategories.
    - 1 Year stacked column spending chart: link to your subcategories.
- **All Accounts:**
    - Add transactions linked to your given accounts and subcategories.
    - Transactions will automatically update your account balance and budget activity.
- **To Be Budgeted:**
    - The "To Be Budgeted" feature on the budget menu is used to give your money a job.
    - It will prompt you to allocate your money to different categories, but don't allocate to much, or you might go in the red.
- **Notes**:
    - Add specific information about bank accounts, stocks, values, diversification and more at one central place.
<br></br>
##  ⌛Download
### **[Releases](https://github.com/MatthiasBenaets/BasedBudgeting/releases)**
### **[Latest Version](https://github.com/MatthiasBenaets/BasedBudgeting/releases/tag/v1.2.1)**
There is the possiblity that Windows will show a message that says something like:

**Windows protected your PC**

This is due to this being a passion project. The application does not have an active Microsoft certificate, since I don't have $400 to spare every year. Therefore, the application is signed by my personal computer.

To run the EXE, you will have to click:

**Show More** --> **Run Anyways**

This prompt will only be diplayed once at first use of the application.
<br></br>
##  🙋FAQ

### **Ask a question [HERE](https://github.com/MatthiasBenaets/BasedBudgeting/discussions)**

**What happens to my budget at the end of the month**

- Within the budget menu, the total available value will get transfered to the new month. The budgeted- and activity-column will get reset to zero. The previous month's budget and account balance will get stored. Navigation buttons will appear to navigate between the past and current budget(s). Within the reports menu, all charts will get updated for the new month.

**Is there a dark mode?**

- Dark mode was briefly implemented but is still very buggy and needs more time to be developed. Unfortunately it's not as easy as just changing the colors.

**Where is all data stored?**

- All data can be found under Roaming App Data. This is done, so data get preserved between releases and so it can easily be transfered if you swap devices.

**Is my device compatible?**

- BasedBudgeting should work on pretty much all actively supported Windows operating systems. By default, the set resolution is 1280x720 but you should be able to resize it to any resolution you prefer.
<br></br>

##  👋Contact
- [Issues or Feature Request](https://github.com/MatthiasBenaets/BasedBudgeting/issues)
- [Resume](https://matthiasbenaets.github.io/)
- [Donate](https://www.paypal.com/donate?hosted_button_id=VXJ2AVMJRQUBY)
<br></br>

## Disclaimer
Based Budgeting is heavily inspired by YNAB.

You Need a Budget (YNAB) is a trademark of You Need A Budget LLC, which is not affiliated with the maker of this project and does not endorse this project.

All assets and names are trademarks of their respective holders. Use of them does not imply any affiliation with or endorsement by them.

