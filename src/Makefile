XBUILD=/Applications/Xcode_14.2.0.app/Contents/Developer/usr/bin/xcodebuild
ROOT=$(PWD)
PROJECT_ROOT=$(ROOT)/../external/Chameleon
PROJECT=$(PROJECT_ROOT)/Chameleon.xcodeproj
BUILD_ROOT=$(PROJECT_ROOT)/build
TARGET_IOS="Chameleon"
TARGET_TVOS="Chameleon"
PROJECTNAME=Chameleon
OUTPUT=$(ROOT)/Build
FRAMEWORK_PATH=Products/Library/Frameworks/Chameleon.framework
FRAMEWORKS=$(ROOT)/Frameworks
FRAMEWORKS_IOS=$(ROOT)/Frameworks/ios
FRAMEWORKS_TVOS=$(ROOT)/Frameworks/tvos
BINDING_OUTPUT=$(ROOT)/../bindings
IOS_SDK=iphoneos16.2
HEADERS=$(FRAMEWORKS)/$(PROJECTNAME).xcframework/ios-arm64/Chameleon.framework/Headers

all: iossimulator iosdevice maccatalyst tvossimulator tvosdevice xcframework dotnet

build: iossimulator iosdevice maccatalyst tvossimulator tvosdevice xcframework

pack: build nuget

iossimulator:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_IOS) -destination "generic/platform=iOS Simulator" -archivePath $(BUILD_ROOT)/simulator.xcarchive -sdk iphonesimulator SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

iosdevice:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_IOS) -destination "generic/platform=iOS" -archivePath $(BUILD_ROOT)/iOS.xcarchive -sdk iphoneos SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

maccatalyst:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_IOS) -destination "generic/platform=macOS,variant=Mac Catalyst,name=Any Mac" -archivePath $(BUILD_ROOT)/catalyst.xcarchive SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

tvossimulator:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_TVOS) -archivePath $(BUILD_ROOT)/tvsimulator.xcarchive -sdk appletvsimulator SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

tvosdevice:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_TVOS) -archivePath $(BUILD_ROOT)/tvos.xcarchive -sdk appletvos SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

xcframework:
	rm -rf $(BUILD_ROOT)/Chameleon.xcframework
	$(XBUILD) -create-xcframework -framework $(BUILD_ROOT)/simulator.xcarchive/$(FRAMEWORK_PATH) -framework $(BUILD_ROOT)/tvsimulator.xcarchive/$(FRAMEWORK_PATH) -framework $(BUILD_ROOT)/tvos.xcarchive/$(FRAMEWORK_PATH) -framework $(BUILD_ROOT)/iOS.xcarchive/$(FRAMEWORK_PATH) -framework $(BUILD_ROOT)/catalyst.xcarchive/$(FRAMEWORK_PATH) -output $(BUILD_ROOT)/Chameleon.xcframework
	rm -rf $(FRAMEWORKS)
	mkdir -p $(FRAMEWORKS)
	cp -R $(BUILD_ROOT)/ $(FRAMEWORKS)

dotnet:
	dotnet build $(ROOT)/Drastic.Chameleon/Drastic.Chameleon.csproj -c Release

nuget:
	dotnet pack $(ROOT)/Drastic.Chameleon/Drastic.Chameleon.csproj --configuration Release --output $(ROOT)/../nuget

sharpie:
	sharpie bind --sdk=$(IOS_SDK) --output="$(BINDING_OUTPUT)" --namespace="Drastic.$(PROJECTNAME)" --scope="$(HEADERS)/" $(HEADERS)/*.h