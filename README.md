# Bank Management System

## Overview

The **Bank Management System** is a robust application developed using C# that provides a comprehensive solution for managing bank accounts and transactions. The system is designed to handle various banking operations, ensuring security, efficiency, and ease of use.

## Features

- **Customer Account Management**: Add and manage customer accounts effortlessly.
- **Admin Access**: Admins can view and manage customer details securely.
- **Cheque Token Generation**: Generate and manage cheque tokens for transactions.
- **Cash Withdrawal**: Process cash withdrawals securely with built-in validation.
- **Balance Check**: Customers can check their account balance in real-time.
- **And More**: Additional features to enhance the banking experience.

## Technology Stack

- **Programming Language**: C#
- **Database**: SQL Server

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/bank-management-system.git
   ```
2. **Setup the Database**:
   - Restore the SQL Server database using the provided `.bak` file or run the SQL scripts to create the necessary tables.

3. **Build the Project**:
   - Open the solution in Visual Studio.
   - Build the project to restore NuGet packages and dependencies.

4. **Run the Application**:
   - Ensure your SQL Server instance is running.
   - Configure the connection string in the `app.config` or `web.config` file.
   - Start the application.

## Usage

- **Admin Access**: Log in as an admin to manage customer accounts and view transactions.
- **Customer Access**: Log in as a customer to check balances, withdraw cash, and generate cheque tokens.