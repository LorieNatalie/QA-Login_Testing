from selenium import webdriver
from selenium.webdriver.common.by import By
import time

driver = webdriver.Chrome()
driver.get("file:///absolute/path/to/qa-login-testing/app/login.html")

driver.find_element(By.ID, "username").send_keys("john_doe")
driver.find_element(By.ID, "password").send_keys("Password123")
driver.find_element(By.TAG_NAME, "button").click()

time.sleep(1)
assert "dashboard.html" in driver.current_url, "❌ Valid login failed!"
print("✅ Valid login test passed!")

driver.quit()
