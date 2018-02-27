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

def CreateAccountNormal( driver, email, username, password, day, month, year ):
	elem = driver.find_element_by_name("email")
	elem.clear()
	elem.send_keys(email)
	elem = driver.find_element_by_name("username")
	elem.clear()
	elem.send_keys(username)
	elem = driver.find_element_by_name("password")
	elem.clear()
	elem.send_keys(password)
	elem = driver.find_element_by_name("confirm_password")
	elem.clear()
	elem.send_keys(password)
	selectDay = Select(driver.find_element_by_name('day')).select_by_visible_text(day)
	selectMonth = Select(driver.find_element_by_name('month')).select_by_visible_text(month)
	selectYear = Select(driver.find_element_by_name('year')).select_by_visible_text(year)
	element = driver.find_element_by_name('tou_agree')
	driver.execute_script("arguments[0].click();", element)
	element = driver.find_element_by_class_name('c-button-primary')
	driver.execute_script("arguments[0].click();", element)
	
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

def CreateAccountNewStyle( driver, email, username, password, day, month, year ):
	elem = driver.find_element_by_id("welcome-email")
	elem.clear()
	elem.send_keys(email)
	ClickButtonStart(driver)
	SelectDOB(driver, 'month')
	SelectDOB(driver, 'day')
	SelectDOB(driver, 'year')
	ClickButtonNext(driver)
	elem = driver.find_element_by_id("register-username")
	elem.clear()
	elem.send_keys(username)
	elem = driver.find_element_by_id("register-password")
	elem.clear()
	elem.send_keys(password)
	elem = driver.find_element_by_id("register-password-again")
	elem.clear()
	elem.send_keys(password)
	element = driver.find_element_by_id('register-terms')
	driver.execute_script("arguments[0].click();", element)
	ClickButtonNext(driver)
	sleep(delay-2)

def StartLoop(region, email, username, password, day, month, year):
	driver = webdriver.Chrome(driverLocation)
	isComplete = False
	while not isComplete:
		driver.get("https://signup." + region +".leagueoflegends.com/en/signup/")
		sleep(delay)
		try:
			CreateAccountNormal(driver, email, username, password, day, month, year)
			isComplete = True
			sleep(delay + 10)
		except: 
			if region == 'na':
				try:
					CreateAccountNewStyle(driver, email, username, password, day, month, year)
					isComplete = True
					sleep(delay + 10)
				except: 
				  driver.close()
				  driver = webdriver.Chrome(driverLocation)
			else:
				driver.close()
				driver = webdriver.Chrome(driverLocation)


with open('accounts.txt') as csvfile:
	# 0 = region, 1= username, 2= password, 3 = birthday, 4=email
	readCSV = csv.reader(csvfile, delimiter=',')
	next(readCSV, None)  # skip the headers
	for row in readCSV:
		dt = parser.parse(row[3])
		StartLoop(row[0], row[4], row[1], row[2], str(dt.day), dt.strftime("%B"), str(dt.year))



print("Account Creation Complete!")
raw_input()

#driver.close()