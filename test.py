from selenium import webdriver
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.common.by import By
from selenium.common.exceptions import TimeoutException
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.support.ui import Select
from time import sleep
import csv
from dateutil import parser




driverLocation='/Users/tarekadel/Script/chromedriver'
delay = 5 #seconds

def ClickButtonStart(driver):
	button = driver.find_element_by_xpath("//button[@class='c-button c-button--fancy c-fancy-form__submit u-color-white']")
	button.click()
	sleep(delay-4)
def ClickButtonNext(driver):
	button = driver.find_element_by_xpath("//button[@class='c-button c-button--fancyStep c-fancy-form__submit']")
	button.click()
	sleep(delay-4)

def SelectDOB(driver,type):
	TextToSelect = '';
	if type == 'day':
		type=1
		TextToSelect = '4'
	elif type == 'month':
		type = 0
		TextToSelect = 'JANUARY'
	elif type == 'year':
		type = 2
		TextToSelect = '2014'
	else:
		return
	driver.find_elements_by_class_name('Select-control')[type].click()
	sleep(delay-4.5)
	options = driver.find_elements_by_class_name('Select-option')
	for option in options:
		if option.text == TextToSelect:
			option.click()
			break
	sleep(delay-3.5)

driver = webdriver.Chrome(driverLocation)
driver.get("https://signup.na.leagueoflegends.com/en/signup/")
sleep(delay)
elem = driver.find_element_by_id("welcome-email")
elem.clear()
elem.send_keys("test@test.com")
ClickButtonStart(driver)
SelectDOB(driver, 'month')
SelectDOB(driver, 'day')
SelectDOB(driver, 'year')
ClickButtonNext(driver)
elem = driver.find_element_by_id("register-username")
elem.clear()
elem.send_keys("username")
elem = driver.find_element_by_id("register-password")
elem.clear()
elem.send_keys("password")
elem = driver.find_element_by_id("register-password-again")
elem.clear()
elem.send_keys("password")
element = driver.find_element_by_id('register-terms')
driver.execute_script("arguments[0].click();", element)
ClickButtonNext(driver)
sleep(delay-2)

sleep(15)