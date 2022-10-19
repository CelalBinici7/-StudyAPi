import requests

URL = "https://api.genshin.dev/characters"

response = requests.get(URL)

print(response.text)