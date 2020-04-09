docker build -t pegasy/argsdemo -f ArgsDemo/Dockerfile .

docker run --rm pegasy/argsdemo abc def --path C:\tmp --url https://github.com/ --switch 1
