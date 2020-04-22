config ?= Debug

build:
	dotnet build -c $(config) SqlDeploy

publish: build
	rm -rf out
	mkdir out
	dotnet publish -c $(config) -r win10-x64 -o $(PWD)/out/win10 SqlDeploy
	cd out/win10; zip -r ../win10.zip ./*

	dotnet publish -c $(config) -r osx-x64 -o $(PWD)/out/osx SqlDeploy
	cd out/osx; zip -r ../osx.zip ./*

	dotnet publish -c $(config) -r linux-x64 -o $(PWD)/out/linux SqlDeploy
	cd out/linux; zip -r ../linux.zip ./*
