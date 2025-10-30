# 🧪 Test Cases for Login Page

| ID | Test Case | Steps | Expected Result | Status |
|----|------------|--------|----------------|--------|
| TC001 | Valid login | Enter `john_doe` / `Password123` → Login | Redirect to dashboard | ✅ |
| TC002 | Invalid login | Enter `john_doe` / `wrongpass` → Login | “Invalid username or password” | ✅ |
| TC003 | Empty username | Leave username blank, enter password → Login | “Username required” | ✅ |
| TC004 | Empty password | Enter username, leave password blank → Login | “Password required” | ✅ |
| TC005 | Both fields empty | Click Login | “Username and password required” | ✅ |
