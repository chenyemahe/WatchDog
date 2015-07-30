S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOD7
Build-Date: 2015.04.16 12:41:35

Crash Information
Process Name: camerasample
PID: 25471
Date: 2015-06-12 05:22:36+0530
Executable File Path: /opt/usr/apps/org.tizen.camerasample/bin/camerasample
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 25471, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0xb4db81a5
r4   = 0x00000000, r5   = 0xb7dbf890
r6   = 0xb7dbf868, r7   = 0xbeeebc54
r8   = 0xb7dbf7c0, r9   = 0x00000168
r10  = 0xb7f6e6b0, fp   = 0x00000001
ip   = 0xb6cb4d60, sp   = 0xbeeebc48
lr   = 0xb4db81c7, pc   = 0xb6cb4d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    136216 KB
Buffers:     37664 KB
Cached:     200196 KB
VmPeak:     257496 KB
VmSize:     257492 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21140 KB
VmRSS:       21136 KB
VmData:     188788 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       27984 KB
VmPTE:         116 KB
VmSwap:          0 KB

Threads Information
Threads: 23
PID = 25471 TID = 25471
25471 25472 25473 25475 25476 25477 25478 25479 25480 25481 25482 25484 25485 25486 25487 25488 25489 25490 25491 25492 25494 25495 25500 

Maps Information
a9601000 a9e00000 rwxp [stack:25495]
a9e01000 aa600000 rwxp [stack:25494]
aa601000 aae00000 rwxp [stack:25500]
aae01000 ab600000 rwxp [stack:25492]
ab601000 abe00000 rwxp [stack:25491]
abe01000 ac600000 rwxp [stack:25490]
ac601000 ace00000 rwxp [stack:25489]
ace01000 ad600000 rwxp [stack:25488]
ad601000 ade00000 rwxp [stack:25487]
ade01000 ae600000 rwxp [stack:25486]
ae601000 aee00000 rwxp [stack:25485]
aee01000 af600000 rwxp [stack:25484]
af601000 afe00000 rwxp [stack:25482]
afe01000 b0600000 rwxp [stack:25481]
b07b1000 b0fb0000 rwxp [stack:25480]
b0fb1000 b17b0000 rwxp [stack:25479]
b17b1000 b1fb0000 rwxp [stack:25478]
b1fb0000 b1fbe000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1fdc000 b2011000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b201a000 b201b000 r-xp /usr/lib/libbincfg.so.1.1
b2023000 b2028000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b2030000 b2076000 r-xp /usr/lib/libcamera-interface-sprd-sc7727.so.0.0.0
b2086000 b20ce000 r-xp /usr/lib/libcamerahal.so.0.0.0
b20dc000 b20e6000 r-xp /usr/lib/gstreamer-0.10/libgstevasimagesink.so
b20ee000 b2104000 r-xp /usr/lib/gstreamer-0.10/libgstcamerasrc.so
b210d000 b290c000 rwxp [stack:25477]
b2922000 b3121000 rwxp [stack:25476]
b3122000 b3921000 rwxp [stack:25475]
b3921000 b3922000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b392a000 b392b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3933000 b393a000 r-xp /usr/lib/libfeedback.so.0.1.4
b3963000 b3964000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b396c000 b3983000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3b2a000 b3b2e000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3b38000 b4337000 rwxp [stack:25472]
b4337000 b447e000 r-xp /usr/lib/driver/libMali.so
b448b000 b4555000 r-xp /usr/lib/libCOREGL.so.4.0
b4566000 b4569000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4571000 b4574000 r-xp /usr/lib/libEGL.so.1.4
b457c000 b458a000 r-xp /usr/lib/libGLESv2.so.2.0
b4593000 b45e3000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4828000 b4967000 r-xp /usr/lib/libicui18n.so.51.1
b4977000 b49d8000 r-xp /usr/lib/libasound.so.2.0.0
b49e2000 b49e6000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b49ee000 b49f1000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b49fa000 b4a03000 r-xp /usr/lib/libmdm-common.so.1.0.45
b4a0b000 b4a53000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4a54000 b4a5a000 r-xp /usr/lib/libjson.so.0.1.0
b4a62000 b4a6a000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b4a79000 b4a7b000 r-xp /usr/lib/libiniparser.so.0
b4a85000 b4a9b000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b4ac9000 b4acc000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4ad4000 b4aea000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b4af2000 b4af6000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b4aff000 b4b42000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b4b4a000 b4b4c000 r-xp /usr/lib/libdri2.so.0.0.0
b4b54000 b4b5b000 r-xp /usr/lib/libdrm.so.2.4.0
b4b64000 b4b68000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4b71000 b4b84000 r-xp /usr/lib/libmdm.so.1.0.88
b4b8c000 b4b92000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b4b9b000 b4ba5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b4bb1000 b4bb9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4bc1000 b4bc3000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
b4bcb000 b4c02000 r-xp /usr/lib/libpulse.so.0.16.2
b4c0b000 b4c10000 r-xp /usr/lib/libmmfsession.so.0.0.0
b4c18000 b4c2d000 r-xp /usr/lib/libmmfsound.so.0.1.0
b4c35000 b4c38000 r-xp /usr/lib/libmm_ta.so.0.0.0
b4c40000 b4c49000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b4c51000 b4c5e000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b4c67000 b4c6e000 r-xp /usr/lib/libtbm.so.1.0.0
b4c76000 b4d11000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b4d1d000 b4d22000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4d2a000 b4d7b000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b4d89000 b4d99000 r-xp /usr/lib/libcapi-media-camera.so.0.1.71
b4da3000 b4dad000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4db6000 b4dba000 r-xp /opt/usr/apps/org.tizen.camerasample/bin/camerasample
b4dc4000 b4dce000 r-xp /lib/libnss_files-2.13.so
b4dd7000 b4de9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4df1000 b4e07000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4e0f000 b4edd000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4ef4000 b4f18000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4f21000 b4f27000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f2f000 b4f3d000 r-xp /usr/lib/libail.so.0.1.0
b4f45000 b4f47000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4f50000 b4f55000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4f5e000 b4f60000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4f68000 b4f69000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4f72000 b4f76000 r-xp /usr/lib/libogg.so.0.7.1
b4f7e000 b4fa0000 r-xp /usr/lib/libvorbis.so.0.4.3
b4fa8000 b508c000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b50a0000 b50d1000 r-xp /usr/lib/libFLAC.so.8.2.0
b5a6b000 b5aff000 r-xp /usr/lib/libstdc++.so.6.0.16
b5b12000 b5b14000 r-xp /usr/lib/libXau.so.6.0.0
b5b1c000 b5b26000 r-xp /usr/lib/libspdy.so.0.0.0
b5b2f000 b5b7b000 r-xp /usr/lib/libssl.so.1.0.0
b5b88000 b5bb6000 r-xp /usr/lib/libidn.so.11.5.44
b5bbe000 b5bc8000 r-xp /usr/lib/libcares.so.2.1.0
b5bd0000 b5bf1000 r-xp /usr/lib/libexif.so.12.3.3
b5c04000 b5c49000 r-xp /usr/lib/libsndfile.so.1.0.25
b5c57000 b5c6d000 r-xp /lib/libexpat.so.1.5.2
b5c76000 b5d5b000 r-xp /usr/lib/libicuuc.so.51.1
b5d70000 b5da4000 r-xp /usr/lib/libicule.so.51.1
b5dad000 b5dc0000 r-xp /usr/lib/libxcb.so.1.1.0
b5dc8000 b5e05000 r-xp /usr/lib/libcurl.so.4.3.0
b5e0e000 b5e17000 r-xp /usr/lib/libethumb.so.1.7.99
b5e20000 b5e22000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e2a000 b5e37000 r-xp /usr/lib/libremix.so.0.0.0
b5e3f000 b5e40000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e48000 b5e5f000 r-xp /usr/lib/liblua-5.1.so
b5e68000 b5e6f000 r-xp /usr/lib/libembryo.so.1.7.99
b5e77000 b5e9a000 r-xp /usr/lib/libjpeg.so.8.0.2
b5eb2000 b5f08000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5f15000 b5f68000 r-xp /usr/lib/libfreetype.so.6.8.1
b5f73000 b5f9b000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5f9c000 b5fe2000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5feb000 b5ffe000 r-xp /usr/lib/libfribidi.so.0.3.1
b6006000 b6009000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6011000 b6015000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b601d000 b6022000 r-xp /usr/lib/libecore_fb.so.1.7.99
b602b000 b6035000 r-xp /usr/lib/libXext.so.6.4.0
b603d000 b611e000 r-xp /usr/lib/libX11.so.6.3.0
b6129000 b612c000 r-xp /usr/lib/libXtst.so.6.1.0
b6134000 b613a000 r-xp /usr/lib/libXrender.so.1.3.0
b6142000 b6147000 r-xp /usr/lib/libXrandr.so.2.2.0
b614f000 b6150000 r-xp /usr/lib/libXinerama.so.1.0.0
b6159000 b6161000 r-xp /usr/lib/libXi.so.6.1.0
b6162000 b6165000 r-xp /usr/lib/libXfixes.so.3.1.0
b616d000 b616f000 r-xp /usr/lib/libXgesture.so.7.0.0
b6177000 b6179000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6181000 b6182000 r-xp /usr/lib/libXdamage.so.1.1.0
b618b000 b6191000 r-xp /usr/lib/libXcursor.so.1.0.2
b619a000 b61b3000 r-xp /usr/lib/libecore_con.so.1.7.99
b61bd000 b61c3000 r-xp /usr/lib/libecore_imf.so.1.7.99
b61cb000 b61d3000 r-xp /usr/lib/libethumb_client.so.1.7.99
b61db000 b61e4000 r-xp /usr/lib/libedbus.so.1.7.99
b61ec000 b6249000 r-xp /usr/lib/libedje.so.1.7.99
b6252000 b6263000 r-xp /usr/lib/libecore_input.so.1.7.99
b626b000 b6270000 r-xp /usr/lib/libecore_file.so.1.7.99
b6278000 b6291000 r-xp /usr/lib/libeet.so.1.7.99
b62a2000 b62a6000 r-xp /usr/lib/libappcore-common.so.1.1
b62ae000 b6375000 r-xp /usr/lib/libevas.so.1.7.99
b639a000 b63bb000 r-xp /usr/lib/libecore_evas.so.1.7.99
b63c4000 b63f3000 r-xp /usr/lib/libecore_x.so.1.7.99
b63fd000 b6534000 r-xp /usr/lib/libelementary.so.1.7.99
b654a000 b654b000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b6553000 b6557000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b6562000 b6565000 r-xp /lib/libgpg-error.so.0.5.0
b656d000 b65c5000 r-xp /usr/lib/libgcrypt.so.11.5.3
b65cf000 b65fb000 r-xp /usr/lib/libsystemd.so.0.0.1
b6604000 b6606000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b660f000 b66da000 r-xp /usr/lib/libxml2.so.2.7.8
b66e8000 b66f8000 r-xp /lib/libresolv-2.13.so
b66fc000 b6712000 r-xp /lib/libz.so.1.2.5
b671a000 b671c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6724000 b6729000 r-xp /usr/lib/libffi.so.5.0.10
b6732000 b6733000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b673b000 b673e000 r-xp /lib/libattr.so.1.1.0
b6746000 b6749000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6751000 b6758000 r-xp /usr/lib/libvconf.so.0.2.45
b6761000 b6909000 r-xp /usr/lib/libcrypto.so.1.0.0
b692a000 b6940000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6948000 b69b1000 r-xp /lib/libm-2.13.so
b69ba000 b69fa000 r-xp /usr/lib/libeina.so.1.7.99
b6a03000 b6a37000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a40000 b6b14000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6b20000 b6b25000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b2e000 b6b34000 r-xp /lib/librt-2.13.so
b6b3d000 b6b44000 r-xp /lib/libcrypt-2.13.so
b6b74000 b6b77000 r-xp /lib/libcap.so.2.21
b6b7f000 b6b81000 r-xp /usr/lib/libiri.so
b6b89000 b6ba8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bb0000 b6bc6000 r-xp /usr/lib/libecore.so.1.7.99
b6bdc000 b6be1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bea000 b6c01000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c0a000 b6c15000 r-xp /lib/libunwind.so.8.0.1
b6c42000 b6d5d000 r-xp /lib/libc-2.13.so
b6d6b000 b6d73000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d7b000 b6da5000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6dae000 b6db1000 r-xp /usr/lib/libbundle.so.0.1.22
b6db9000 b6dbb000 r-xp /lib/libdl-2.13.so
b6dc4000 b6dc7000 r-xp /usr/lib/libsmack.so.1.0.0
b6dcf000 b6e9f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6ea0000 b6f05000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6f0f000 b6f21000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f29000 b6f3d000 r-xp /lib/libpthread-2.13.so
b6f48000 b6f4a000 r-xp /usr/lib/libdlog.so.0.0.0
b6f52000 b6f5d000 r-xp /usr/lib/libaul.so.0.1.0
b6f6b000 b6f6e000 rwxp [stack:25473]
b6f6f000 b6f72000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f7c000 b6f80000 r-xp /usr/lib/libsys-assert.so
b6f89000 b6fa6000 r-xp /lib/ld-2.13.so
b6faf000 b6fb4000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7bce000 b7bf8000 rw-p [heap]
b7bf8000 b8046000 rw-p [heap]
beecc000 beeed000 rwxp [stack]
End of Maps Information

Callstack Information (PID:25471)
Call Stack Count: 2
 0: strlen + 0x4 (0xb6cb4d64) [/lib/libc.so.6] + 0x72d64
 1: _main_view_btn_click_cb + 0x22 (0xb4db81c7) [/opt/usr/apps/org.tizen.camerasample/bin/camerasample] + 0x21c7
End of Call Stack

Package Information
Package Name: org.tizen.camerasample
Package ID : org.tizen.camerasample
Version: 1.0.0
Package Type: rpm
App Name: camerasample
App ID: org.tizen.camerasample
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
= [org.tizen.camerasample], Key = [start], Value = [update], install = [96]
06-12 05:20:29.768+0530 W/AUL_AMD (  455): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
06-12 05:20:29.768+0530 I/Tizen::App( 1055): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.camerasample, key: install_percent, val: 30
06-12 05:20:29.768+0530 I/Tizen::App( 1055): (119) > InstallationInProgress [30]
06-12 05:20:29.768+0530 I/Tizen::App( 1055): (1584) > Package = [org.tizen.camerasample], Key = [install_percent], Value = [30], install = [1]
06-12 05:20:29.828+0530 I/CAPI_APPFW_APPLICATION(24780): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:29.828+0530 I/CAPI_APPFW_APPLICATION( 1142): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:29.828+0530 I/CAPI_APPFW_APPLICATION( 1210): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:29.828+0530 W/CAM_APP ( 1210): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-12 05:20:29.898+0530 I/CAPI_APPFW_APPLICATION( 7595): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:30.068+0530 I/CAPI_APPFW_APPLICATION(24780): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:30.068+0530 I/CAPI_APPFW_APPLICATION( 1142): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:30.068+0530 I/CAPI_APPFW_APPLICATION( 1210): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:30.068+0530 W/CAM_APP ( 1210): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-12 05:20:30.138+0530 I/CAPI_APPFW_APPLICATION(24780): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:30.138+0530 I/CAPI_APPFW_APPLICATION( 1142): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:30.138+0530 I/CAPI_APPFW_APPLICATION( 7595): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:30.138+0530 I/CAPI_APPFW_APPLICATION( 1210): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:30.138+0530 W/CAM_APP ( 1210): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-12 05:20:30.278+0530 I/CAPI_APPFW_APPLICATION( 7595): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:30.458+0530 E/PKGMGR_CERT(24988): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-12 05:20:30.468+0530 E/PKGMGR_CERT(24988): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 88
06-12 05:20:30.468+0530 E/PKGMGR_CERT(24988): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 88
06-12 05:20:30.468+0530 E/PKGMGR_CERT(24988): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 2
06-12 05:20:30.468+0530 I/Tizen::App( 1055): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.camerasample, key: install_percent, val: 60
06-12 05:20:30.468+0530 E/PKGMGR_CERT(24988): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 46 2
06-12 05:20:30.468+0530 I/Tizen::App( 1055): (119) > InstallationInProgress [60]
06-12 05:20:30.468+0530 I/Tizen::App( 1055): (1584) > Package = [org.tizen.camerasample], Key = [install_percent], Value = [60], install = [96]
06-12 05:20:30.468+0530 E/PKGMGR_CERT(24988): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 47 2
06-12 05:20:30.468+0530 E/PKGMGR_CERT(24988): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 48 2
06-12 05:20:30.488+0530 E/PKGMGR_CERT(24988): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
06-12 05:20:30.488+0530 E/rpm-installer(24988): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.camerasample/shared], errno=[2][No such file or directory]
06-12 05:20:30.488+0530 E/rpm-installer(24988): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.camerasample/shared]
06-12 05:20:30.488+0530 E/rpm-installer(24988): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.camerasample/shared/data]
06-12 05:20:30.488+0530 E/rpm-installer(24988): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.camerasample/shared/res]
06-12 05:20:30.488+0530 E/rpm-installer(24988): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.camerasample/tizen-manifest.xml]
06-12 05:20:30.488+0530 E/rpm-installer(24988): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.camerasample/author-signature.xml]
06-12 05:20:30.488+0530 E/rpm-installer(24988): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.camerasample/signature1.xml]
06-12 05:20:30.488+0530 E/rpm-installer(24988): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.camerasample.xml]
06-12 05:20:30.938+0530 E/rpm-installer(24988): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.camerasample/shared/data]))
06-12 05:20:31.368+0530 E/PKGMGR_SERVER(24985): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-12 05:20:32.058+0530 E/PKGMGR_INFO(24988): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
06-12 05:20:32.058+0530 E/PKGMGR_INSTALLER(24988): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
06-12 05:20:32.068+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
06-12 05:20:32.068+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
06-12 05:20:32.068+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
06-12 05:20:32.088+0530 I/Tizen::App( 1055): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.camerasample, key: install_percent, val: 100
06-12 05:20:32.088+0530 I/Tizen::App( 1055): (119) > InstallationInProgress [100]
06-12 05:20:32.088+0530 I/Tizen::App( 1055): (1584) > Package = [org.tizen.camerasample], Key = [install_percent], Value = [100], install = [96]
06-12 05:20:32.088+0530 I/Tizen::App( 1055): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.camerasample, key: end, val: ok
06-12 05:20:32.088+0530 I/Tizen::App( 1055): (78) > Installation is Completed. [Package = org.tizen.camerasample]
06-12 05:20:32.088+0530 I/Tizen::App( 1055): (663) > Enter. package(org.tizen.camerasample), installationResult(0)
06-12 05:20:32.098+0530 I/Tizen::App( 1055): (1360) > package(org.tizen.camerasample), version(1.0.0), type(rpm), displayName(camerasample), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.camerasample), storeClient(), appRootPath(/opt/usr/apps/org.tizen.camerasample)
06-12 05:20:32.118+0530 I/Tizen::App( 1055): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.camerasample]
06-12 05:20:32.128+0530 I/Tizen::App( 1055): (416) > appName = [camerasample]
06-12 05:20:32.128+0530 I/Tizen::App( 1055): (509) > exe = [/opt/usr/apps/org.tizen.camerasample/bin/camerasample], displayName = [camerasample], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-12 05:20:32.128+0530 E/PKGMGR_INFO( 1055): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-12 05:20:32.128+0530 I/Tizen::App( 1055): (675) > Application count(1) in this package
06-12 05:20:32.128+0530 I/Tizen::App( 1055): (855) > Enter.
06-12 05:20:32.128+0530 I/Tizen::App( 1055): (695) > Exit.
06-12 05:20:32.128+0530 I/Tizen::App( 1055): (1584) > Package = [org.tizen.camerasample], Key = [end], Value = [ok], install = [96]
06-12 05:20:32.138+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.camerasample]
06-12 05:20:32.138+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.camerasample]
06-12 05:20:32.138+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
06-12 05:20:32.138+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
06-12 05:20:32.138+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.camerasample]
06-12 05:20:32.138+0530 I/Tizen::App( 1055): (416) > appName = [camerasample]
06-12 05:20:32.138+0530 I/Tizen::App( 1055): (509) > exe = [/opt/usr/apps/org.tizen.camerasample/bin/camerasample], displayName = [camerasample], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-12 05:20:32.138+0530 I/Tizen::App( 1055): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.camerasample.info]
06-12 05:20:32.138+0530 I/Tizen::App( 1055): (131) > Enter
06-12 05:20:32.148+0530 I/Tizen::App( 1055): (137) > org.tizen.camerasample does not have launch condition
06-12 05:20:32.148+0530 I/Tizen::App( 1055): (898) > Exit.
06-12 05:20:32.148+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.camerasample] Name[camerasample] Icon[/opt/usr/apps/org.tizen.camerasample/shared/res/camerasample.png] enable[1] system[0]
06-12 05:20:32.148+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.camerasample] Name[camerasample] Icon[/opt/usr/apps/org.tizen.camerasample/shared/res/camerasample.png] enable[1] system[0]
06-12 05:20:33.368+0530 E/PKGMGR_SERVER(24985): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-12 05:20:33.368+0530 E/PKGMGR_SERVER(24985): pkgmgr-server.c: main(1704) > package manager server terminated.
06-12 05:20:35.468+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 0
06-12 05:20:35.478+0530 I/AUL     (  455): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
06-12 05:20:35.478+0530 I/AUL     (  455): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
06-12 05:20:35.478+0530 E/AUL_AMD (  455): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-12 05:20:35.568+0530 I/CAPI_APPFW_APPLICATION(25063): app_main.c: ui_app_main(699) > app_efl_main
06-12 05:20:35.618+0530 E/RESOURCED(  814): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 405
06-12 05:20:35.628+0530 I/Tizen::App( 1126): (733) > Finished invoking application event listener for org.tizen.camerasample, 25063.
06-12 05:20:35.638+0530 I/Tizen::App( 1055): (499) > LaunchedApp(org.tizen.camerasample)
06-12 05:20:35.638+0530 I/Tizen::App( 1055): (733) > Finished invoking application event listener for org.tizen.camerasample, 25063.
06-12 05:20:35.668+0530 I/CAPI_APPFW_APPLICATION(25063): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-12 05:20:35.948+0530 W/TIZEN_N_CAMERA(25063): camera.c: camera_create(764) > [camera_create]device name = [1]
06-12 05:20:35.958+0530 W/PROCESSMGR(  420): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=25063
06-12 05:20:35.998+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
06-12 05:20:36.028+0530 I/MALI    (  604): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb7d42030] swap changed from sync to async
06-12 05:20:36.028+0530 W/TIZEN_N_CAMERA(25063): camera.c: camera_create(824) > camera handle 0xb7dc3fa0
06-12 05:20:36.028+0530 W/TIZEN_N_CAMERA(25063): camera.c: camera_start_preview(869) > camera_start_preview - start
06-12 05:20:36.038+0530 I/indicator(  501): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.camerasample, pid = 25063"
06-12 05:20:36.048+0530 I/Tizen::System( 1126): (259) > Active app [org.tizen.], current [com.samsun] 
06-12 05:20:36.048+0530 I/Tizen::Io( 1126): (729) > Entry not found
06-12 05:20:36.058+0530 I/Tizen::System( 1126): (157) > change brightness system value.
06-12 05:20:36.598+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-12 05:20:36.598+0530 W/AUL_AMD (  455): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
06-12 05:20:37.298+0530 E/TIZEN_N_CAMERA(25063): camera.c: __convert_camera_error_code(234) > [__camera_start_continuous_focusing] ERROR_NOT_SUPPORTED(0xc0000002) : core frameworks error code(0x80000107)
06-12 05:20:37.308+0530 E/EFL     (25063): evas_main<25063> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-12 05:20:37.328+0530 E/EFL     (25063): evas_main<25063> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-12 05:20:37.448+0530 I/CAPI_APPFW_APPLICATION(25063): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-12 05:20:37.458+0530 I/APP_CORE(25063): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-12 05:20:37.458+0530 I/APP_CORE(25063): appcore-efl.c: __do_app(511) > [APP 25063] Initial Launching, call the resume_cb
06-12 05:20:37.458+0530 I/CAPI_APPFW_APPLICATION(25063): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-12 05:20:37.468+0530 W/APP_CORE(25063): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5000003
06-12 05:20:37.518+0530 W/TIZEN_N_CAMERA(25063): camera.c: __idle_cb(738) > user_cb[type 10] is NULL
06-12 05:20:37.528+0530 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-12 05:20:37.528+0530 E/cluster-home(  604): homescreen-main.cpp: app_pause(355) >  app pause
06-12 05:20:37.558+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-12 05:20:37.558+0530 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-12 05:20:39.898+0530 I/MALI    (25063): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7c8f388] swap changed from async to sync
06-12 05:20:42.938+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-12 05:20:42.938+0530 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-12 05:20:42.998+0530 W/PROCESSMGR(  420): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=604
06-12 05:20:43.018+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
06-12 05:20:43.018+0530 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-12 05:20:43.018+0530 E/cluster-home(  604): homescreen-main.cpp: app_resume(422) >  app resume
06-12 05:20:43.038+0530 W/CRASH_MANAGER(25122): worker.c: worker_job(1236) > 112506363616d1434066642
06-12 05:20:43.048+0530 I/AUL_PAD (  499): sigchild.h: __launchpad_sig_child(142) > dead_pid = 25063 pgid = 25063
06-12 05:20:43.048+0530 I/AUL_PAD (  499): sigchild.h: __sigchild_action(123) > dead_pid(25063)
06-12 05:20:43.048+0530 I/AUL_PAD (  499): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-12 05:20:43.048+0530 I/AUL_PAD (  499): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-12 05:20:43.058+0530 I/Tizen::System( 1126): (259) > Active app [com.samsun], current [org.tizen.] 
06-12 05:20:43.058+0530 I/Tizen::Io( 1126): (729) > Entry not found
06-12 05:20:43.068+0530 I/AUL_AMD (  455): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 25063
06-12 05:20:43.068+0530 I/indicator(  501): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 604"
06-12 05:20:43.078+0530 I/Tizen::App( 1055): (243) > App[org.tizen.camerasample] pid[25063] terminate event is forwarded
06-12 05:20:43.078+0530 I/Tizen::System( 1055): (256) > osp.accessorymanager.service provider is found.
06-12 05:20:43.078+0530 I/Tizen::System( 1055): (196) > Accessory Owner is removed [org.tizen.camerasample, 25063, ]
06-12 05:20:43.078+0530 I/Tizen::System( 1055): (256) > osp.system.service provider is found.
06-12 05:20:43.078+0530 I/Tizen::App( 1055): (506) > TerminatedApp(org.tizen.camerasample)
06-12 05:20:43.078+0530 I/Tizen::App( 1055): (512) > Not registered pid(25063)
06-12 05:20:43.078+0530 I/Tizen::App( 1055): (782) > Finished invoking application event listener for org.tizen.camerasample, 25063.
06-12 05:20:43.128+0530 I/Tizen::System( 1126): (157) > change brightness system value.
06-12 05:20:43.128+0530 I/Tizen::System( 1126): (246) > Terminated app [org.tizen.camerasample]
06-12 05:20:43.128+0530 I/Tizen::Io( 1126): (729) > Entry not found
06-12 05:20:43.138+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 0
06-12 05:20:43.188+0530 I/Tizen::System( 1126): (157) > change brightness system value.
06-12 05:20:43.188+0530 I/Tizen::App( 1126): (782) > Finished invoking application event listener for org.tizen.camerasample, 25063.
06-12 05:20:43.498+0530 I/CAPI_APPFW_APPLICATION(16766): app_main.c: ui_app_main(699) > app_efl_main
06-12 05:20:43.508+0530 I/CAPI_APPFW_APPLICATION(16766): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-12 05:20:43.578+0530 E/RESOURCED(  814): proc-main.c: find_pid_info(96) > [find_pid_info,96] Please provide valid pointer.
06-12 05:20:43.588+0530 E/cluster-home(  604): mainmenu-custom-box-impl.cpp: OnClicked(339) >  Success to launch [0][com.samsung.contacts]
06-12 05:20:43.598+0530 E/RESOURCED(  814): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 403
06-12 05:20:43.628+0530 W/PROCESSMGR(  420): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=16766
06-12 05:20:43.648+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
06-12 05:20:43.658+0530 I/EFL-ASSIST(16766): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b89e1a80) from (/usr/apps/com.samsung.contacts/shared/res/table/com.samsung.contacts_ChangeableColorInfo.xml) is created
06-12 05:20:43.658+0530 I/indicator(  501): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.phone, pid = 16766"
06-12 05:20:43.658+0530 I/EFL-ASSIST(16766): efl_assist_theme_font.c: ea_theme_font_table_new(393) > font table (b8a091e8) from (/usr/apps/com.samsung.contacts/shared/res/table/com.samsung.contacts_ChangeableFontInfo.xml) is created
06-12 05:20:43.658+0530 I/EFL-ASSIST(16766): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [b88543e8]
06-12 05:20:43.688+0530 I/Tizen::System( 1126): (259) > Active app [com.samsun], current [com.samsun] 
06-12 05:20:43.688+0530 I/Tizen::System( 1126): (273) > Current App[com.samsun] is already actived.
06-12 05:20:43.688+0530 I/EFL-ASSIST(16766): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b8a093e0) from (/usr/share/themes/ChangeableColorTable1.xml) is created
06-12 05:20:43.688+0530 I/EFL-ASSIST(16766): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b8a093e0) is freed
06-12 05:20:43.698+0530 I/EFL-ASSIST(16766): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b8a093e0) from (/usr/share/themes/ChangeableColorTable1.xml) is created
06-12 05:20:43.698+0530 I/EFL-ASSIST(16766): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b8a093e0) is freed
06-12 05:20:43.768+0530 I/CAPI_APPFW_APPLICATION(16766): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-12 05:20:43.768+0530 I/PHONE   (16766): ContactsApp.cpp: onAppControl(216) > [0;32mit is first launch![0;m
06-12 05:20:43.768+0530 I/PHONE   (16766): ContactsApp.cpp: onAppControl(224) > [0;32mcalleeId com.samsung.contacts[0;m
06-12 05:20:43.778+0530 I/APP_CORE(16766): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-12 05:20:43.778+0530 I/APP_CORE(16766): appcore-efl.c: __do_app(511) > [APP 16766] Initial Launching, call the resume_cb
06-12 05:20:43.778+0530 I/CAPI_APPFW_APPLICATION(16766): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-12 05:20:43.788+0530 W/UI_GADGET(16766): manager.c: ugman_resume(1045) > [34mugman_resume failed: no root[0m
06-12 05:20:43.798+0530 I/PHONE   (16766): ContactsCommon.cpp: getAppControlData(210) > [0;32mkey: appcontrol_key_appid, value: com.samsung.contacts[0;m
06-12 05:20:43.808+0530 W/CAPI_APPFW_APP_CONTROL(16766): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 05:20:43.808+0530 W/CAPI_APPFW_APP_CONTROL(16766): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 05:20:43.838+0530 W/CAPI_APPFW_APP_CONTROL(16766): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 05:20:43.838+0530 W/CAPI_APPFW_APP_CONTROL(16766): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 05:20:43.838+0530 W/CAPI_APPFW_APP_CONTROL(16766): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 05:20:43.838+0530 W/CAPI_APPFW_APP_CONTROL(16766): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 05:20:43.838+0530 W/CAPI_APPFW_APP_CONTROL(16766): app_control.c: app_control_error(135) > [app_control_get_extra_data_array] KEY_NOT_FOUND(0xffffff82)
06-12 05:20:43.838+0530 W/CAPI_APPFW_APP_CONTROL(16766): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 05:20:43.838+0530 W/CAPI_APPFW_APP_CONTROL(16766): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 05:20:43.838+0530 W/CAPI_APPFW_APP_CONTROL(16766): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 05:20:43.838+0530 W/CAPI_APPFW_APP_CONTROL(16766): app_control.c: app_control_error(135) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 05:20:43.908+0530 E/EFL     (16766): evas_main<16766> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-12 05:20:43.928+0530 E/EFL     (16766): evas_main<16766> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-12 05:20:43.948+0530 E/PHONE   (16766): CtTabView.cpp: __tabChanged(246) > [0;31m* Critical * page item not added[0;m
06-12 05:20:44.078+0530 I/Tizen::App( 1126): (733) > Finished invoking application event listener for com.samsung.phone, 16766.
06-12 05:20:44.108+0530 I/Tizen::App( 1055): (499) > LaunchedApp(com.samsung.phone)
06-12 05:20:44.108+0530 I/Tizen::App( 1055): (733) > Finished invoking application event listener for com.samsung.phone, 16766.
06-12 05:20:44.208+0530 W/WAPP    (16766): WView.cpp: getNaviframe(303) > [0;35mnaviframe does not exist![0;m
06-12 05:20:44.208+0530 E/EFL     (16766): elementary<16766> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-12 05:20:44.208+0530 E/EFL     (16766): elementary<16766> elm_widget.c:4836 _elm_widget_item_del() Elm_Widget_Item item is NULL
06-12 05:20:44.208+0530 E/EFL     (16766): elementary<16766> elm_genlist.c:6112 elm_genlist_item_next_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-12 05:20:44.208+0530 E/EFL     (16766): elementary<16766> elm_widget.c:4836 _elm_widget_item_del() Elm_Widget_Item item is NULL
06-12 05:20:44.208+0530 E/EFL     (16766): elementary<16766> elm_genlist.c:7082 elm_genlist_item_select_mode_set() Elm_Widget_Item ((Elm_Widget_Item *)it) is NULL
06-12 05:20:44.258+0530 E/EFL     (16766): elementary<16766> elm_layout.c:833 _elm_layout_smart_content_set() could not swallow 0xb8b89c10 into part 'title_left_text_btn'
06-12 05:20:44.268+0530 E/EFL     (16766): elementary<16766> elm_layout.c:833 _elm_layout_smart_content_set() could not swallow 0xb8b8ab30 into part 'title_right_text_btn'
06-12 05:20:44.288+0530 W/APP_CORE(16766): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5a00003
06-12 05:20:44.348+0530 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-12 05:20:44.348+0530 E/cluster-home(  604): homescreen-main.cpp: app_pause(355) >  app pause
06-12 05:20:44.528+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.528+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.528+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.548+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.548+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.548+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.568+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.568+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.568+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.588+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.588+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.588+0530 E/CAPI_TELEPHONY(16766): telephony_sim.c: telephony_sim_get_subscriber_number(390) > g_dbus_conn failed. error (GDBus.Error:org.freedesktop.DBus.Error.Failed: SIM NOT FOUND)
06-12 05:20:44.588+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.598+0530 E/CAPI_TELEPHONY(16766): telephony_sim.c: telephony_sim_get_subscriber_number(390) > g_dbus_conn failed. error (GDBus.Error:org.freedesktop.DBus.Error.Failed: SIM NOT FOUND)
06-12 05:20:44.598+0530 E/PHONE   (16766): CtListView.cpp: __initMyProfile(560) > [0;31m* Critical * no msisdn[0;m
06-12 05:20:44.608+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.608+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.608+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.618+0530 E/PHONE   (16766): CtCommon.cpp: ctCommonGetAddressbookIsEas(1266) > [0;31m* Critical * account_query_account_by_account_id() Failed(-22)[0;m
06-12 05:20:44.628+0530 E/PHONE   (16766): CtThread.cpp: __ctThreadTimerCb(90) > [0;31m* Critical * thread alive yet[0;m
06-12 05:20:44.648+0530 E/EFL     (16766): elementary<16766> elm_genlist.c:7082 elm_genlist_item_select_mode_set() Elm_Widget_Item ((Elm_Widget_Item *)it) is NULL
06-12 05:20:45.158+0530 I/UXT     (25138): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-12 05:20:45.308+0530 W/PHONE   (16766): PhLogIcu.cpp: __getDateByBestPattern(91) > [0;35mICU cache updated![0;m
06-12 05:20:46.348+0530 I/MALI    (16766): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb889bb78] swap changed from async to sync
06-12 05:20:46.418+0530 I/EFL-ASSIST(16766): efl_assist_events.c: _ea_key_grab_rect_key_up_cb(281) > [-1226436884] key callback called to [%s: %s(%d) > [%d] key callback called to [%s]]
06-12 05:20:46.418+0530 I/EFL-ASSIST(16766): efl_assist_events.c: _ea_key_grab_rect_key_up_cb(281) > [-1226436884] key callback called to [%s: %s(%d) > [%d] key callback called to [%s]]
06-12 05:20:46.428+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-12 05:20:46.428+0530 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-12 05:20:46.498+0530 W/PROCESSMGR(  420): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=604
06-12 05:20:46.508+0530 I/MALI    (16766): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb889bb78] swap changed from sync to async
06-12 05:20:46.558+0530 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-12 05:20:46.558+0530 E/cluster-home(  604): homescreen-main.cpp: app_resume(422) >  app resume
06-12 05:20:46.558+0530 I/Tizen::System( 1126): (259) > Active app [com.samsun], current [com.samsun] 
06-12 05:20:46.558+0530 I/Tizen::System( 1126): (273) > Current App[com.samsun] is already actived.
06-12 05:20:46.638+0530 I/CAPI_APPFW_APPLICATION(16766): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
06-12 05:20:46.638+0530 W/UI_GADGET(16766): manager.c: ugman_pause(1070) > [34mugman_pause failed: no root[0m
06-12 05:20:46.738+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
06-12 05:20:46.748+0530 I/indicator(  501): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 604"
06-12 05:20:47.048+0530 I/RESOURCED(  814): logging.c: broadcast_logging_data_updated_signal(714) > [broadcast_logging_data_updated_signal,714] broadcast logging_data updated signal!
06-12 05:20:48.118+0530 I/CAPI_APPFW_APPLICATION(24780): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:48.118+0530 I/CAPI_APPFW_APPLICATION( 1142): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:48.118+0530 I/CAPI_APPFW_APPLICATION( 1210): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:48.118+0530 W/CAM_APP ( 1210): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-12 05:20:48.188+0530 I/CAPI_APPFW_APPLICATION( 7595): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:20:48.878+0530 I/MALI    (  604): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7d42030] swap changed from async to sync
06-12 05:20:59.998+0530 I/CAPI_NETWORK_CONNECTION(24780): connection.c: connection_create(363) > New handle created[0xb7eb9340]
06-12 05:20:59.998+0530 I/CAPI_NETWORK_CONNECTION(24780): connection.c: connection_get_type(412) > Connected Network = 2
06-12 05:20:59.998+0530 I/CAPI_NETWORK_CONNECTION(24780): connection.c: connection_destroy(379) > Destroy handle: 0xb7eb9340
06-12 05:20:59.998+0530 E/weather-live(24780): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
06-12 05:20:59.998+0530 I/CAPI_NETWORK_CONNECTION(24780): connection.c: connection_create(363) > New handle created[0xb7f4d5d8]
06-12 05:20:59.998+0530 I/CAPI_NETWORK_CONNECTION(24780): connection.c: connection_get_type(412) > Connected Network = 2
06-12 05:20:59.998+0530 I/CAPI_NETWORK_CONNECTION(24780): connection.c: connection_destroy(379) > Destroy handle: 0xb7f4d5d8
06-12 05:21:00.008+0530 E/weather-live(24780): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-12 05:21:00.028+0530 E/weather-live(24780): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-12 05:21:00.048+0530 E/weather-live(24780): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
06-12 05:21:00.068+0530 E/weather-common(24780): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
06-12 05:21:00.068+0530 E/weather-common(24780): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
06-12 05:21:00.088+0530 E/cluster-home(  604): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 91 362 5 28 25"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 97 418 5 28 25"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 91 682 5 28 25"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 97 738 5 28 25"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] RSSI 0!"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: icon_box_pack(720) > "Pack to FIXED list : RSSI"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-12 05:21:48.298+0530 I/indicator(  501): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
06-12 05:21:48.298+0530 I/EFL-ASSIST(  501): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 2137c20 (elm_image), color code: AO004, color [255, 255, 255, 255]
06-12 05:21:48.308+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-12 05:21:48.308+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 91 362 5 28 25"
06-12 05:21:48.308+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
06-12 05:21:48.308+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 97 418 5 28 25"
06-12 05:21:48.308+0530 I/indicator(  501): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] RSSI 1!"
06-12 05:21:48.308+0530 I/indicator(  501): indicator_box_util.c: icon_box_pack(720) > "Pack to FIXED list : RSSI"
06-12 05:21:48.308+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-12 05:21:48.308+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-12 05:21:48.308+0530 I/indicator(  501): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
06-12 05:21:48.308+0530 I/EFL-ASSIST(  501): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 214a150 (elm_image), color code: AO004, color [255, 255, 255, 255]
06-12 05:21:48.308+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-12 05:21:48.308+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 91 682 5 28 25"
06-12 05:21:48.308+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
06-12 05:21:48.308+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 97 738 5 28 25"
06-12 05:21:53.888+0530 I/CAPI_APPFW_APPLICATION(24780): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:21:53.888+0530 I/CAPI_APPFW_APPLICATION( 1142): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:21:53.888+0530 I/CAPI_APPFW_APPLICATION( 1210): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:21:53.898+0530 W/CAM_APP ( 1210): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-12 05:21:53.958+0530 I/CAPI_APPFW_APPLICATION(16766): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:21:53.958+0530 I/CAPI_APPFW_APPLICATION( 7595): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
06-12 05:21:55.188+0530 W/test-log(  604): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
06-12 05:21:55.188+0530 W/test-log(  604): mainmenu-page-impl.cpp: SetPageEditMode(554) >  editState:[1]
06-12 05:21:55.978+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 1
06-12 05:21:56.058+0530 I/CAPI_APPFW_APPLICATION(25471): app_main.c: ui_app_main(699) > app_efl_main
06-12 05:21:56.098+0530 E/RESOURCED(  814): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 397
06-12 05:21:56.128+0530 I/Tizen::App( 1055): (499) > LaunchedApp(org.tizen.camerasample)
06-12 05:21:56.128+0530 I/Tizen::App( 1055): (733) > Finished invoking application event listener for org.tizen.camerasample, 25471.
06-12 05:21:56.128+0530 I/Tizen::App( 1126): (733) > Finished invoking application event listener for org.tizen.camerasample, 25471.
06-12 05:21:56.148+0530 I/CAPI_APPFW_APPLICATION(25471): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-12 05:21:56.398+0530 W/TIZEN_N_CAMERA(25471): camera.c: camera_create(764) > [camera_create]device name = [1]
06-12 05:21:56.408+0530 W/PROCESSMGR(  420): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=25471
06-12 05:21:56.448+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
06-12 05:21:56.458+0530 I/MALI    (  604): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb7d42030] swap changed from sync to async
06-12 05:21:56.458+0530 I/indicator(  501): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.camerasample, pid = 25471"
06-12 05:21:56.478+0530 W/TIZEN_N_CAMERA(25471): camera.c: camera_create(824) > camera handle 0xb7dc3b30
06-12 05:21:56.478+0530 W/TIZEN_N_CAMERA(25471): camera.c: camera_start_preview(869) > camera_start_preview - start
06-12 05:21:56.478+0530 I/Tizen::System( 1126): (259) > Active app [org.tizen.], current [com.samsun] 
06-12 05:21:56.478+0530 I/Tizen::Io( 1126): (729) > Entry not found
06-12 05:21:56.508+0530 I/Tizen::System( 1126): (157) > change brightness system value.
06-12 05:21:57.738+0530 E/TIZEN_N_CAMERA(25471): camera.c: __convert_camera_error_code(234) > [__camera_start_continuous_focusing] ERROR_NOT_SUPPORTED(0xc0000002) : core frameworks error code(0x80000107)
06-12 05:21:57.748+0530 E/EFL     (25471): evas_main<25471> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-12 05:21:57.768+0530 E/EFL     (25471): evas_main<25471> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-12 05:21:57.878+0530 I/CAPI_APPFW_APPLICATION(25471): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-12 05:21:57.888+0530 I/APP_CORE(25471): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-12 05:21:57.888+0530 I/APP_CORE(25471): appcore-efl.c: __do_app(511) > [APP 25471] Initial Launching, call the resume_cb
06-12 05:21:57.888+0530 I/CAPI_APPFW_APPLICATION(25471): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-12 05:21:57.898+0530 W/APP_CORE(25471): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5600003
06-12 05:21:57.948+0530 W/TIZEN_N_CAMERA(25471): camera.c: __idle_cb(738) > user_cb[type 10] is NULL
06-12 05:21:57.968+0530 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-12 05:21:57.968+0530 E/cluster-home(  604): homescreen-main.cpp: app_pause(355) >  app pause
06-12 05:21:57.998+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-12 05:21:57.998+0530 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-12 05:22:00.348+0530 I/MALI    (25471): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb7c8f0b0] swap changed from async to sync
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 91 362 5 28 25"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 97 418 5 28 25"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 91 682 5 28 25"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 97 738 5 28 25"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] RSSI 0!"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: icon_box_pack(720) > "Pack to FIXED list : RSSI"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-12 05:22:07.358+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-12 05:22:07.368+0530 I/indicator(  501): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
06-12 05:22:07.368+0530 I/EFL-ASSIST(  501): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 2149910 (elm_image), color code: AO004, color [255, 255, 255, 255]
06-12 05:22:07.368+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-12 05:22:07.368+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 91 362 5 28 25"
06-12 05:22:07.368+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
06-12 05:22:07.378+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 97 418 5 28 25"
06-12 05:22:07.378+0530 I/indicator(  501): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] RSSI 1!"
06-12 05:22:07.378+0530 I/indicator(  501): indicator_box_util.c: icon_box_pack(720) > "Pack to FIXED list : RSSI"
06-12 05:22:07.378+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-12 05:22:07.378+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-12 05:22:07.378+0530 I/indicator(  501): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
06-12 05:22:07.378+0530 I/EFL-ASSIST(  501): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 205abf8 (elm_image), color code: AO004, color [255, 255, 255, 255]
06-12 05:22:07.378+0530 I/indicator(  501): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-12 05:22:07.378+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 91 682 5 28 25"
06-12 05:22:07.378+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
06-12 05:22:07.378+0530 I/indicator(  501): indicator_box_util.c: _update_display(585) > "Noti Icon : 97 738 5 28 25"
06-12 05:22:28.008+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 27
06-12 05:22:28.028+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 22
06-12 05:22:28.028+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(803) > app status : 5
06-12 05:22:28.038+0530 I/APP_CORE(24780): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
06-12 05:22:28.048+0530 I/CAPI_APPFW_APPLICATION(24780): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
06-12 05:22:28.118+0530 I/CAPI_NETWORK_CONNECTION(24780): connection.c: connection_destroy(379) > Destroy handle: 0xb7cc1f18
06-12 05:22:28.118+0530 I/CAPI_NETWORK_CONNECTION(24780): connection.c: __connection_set_type_changed_callback(157) > Successfully de-registered(0)
06-12 05:22:28.138+0530 I/EFL-ASSIST(24780): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b7c75360) is freed
06-12 05:22:28.138+0530 I/EFL-ASSIST(24780): efl_assist_theme_font.c: ea_theme_font_table_free(407) > color table (b7c64a50) is freed
06-12 05:22:28.138+0530 E/TIZEN_N_SYSTEM_SETTINGS(24780): system_settings_vconf.c: system_setting_vconf_unset_changed_cb(278) > [system_setting_vconf_unset_changed_cb] vconf_ignore_key_changed : db/setting/accessibility/font_size --- ret = 0 --- callback ptr : b4d6edfd
06-12 05:22:28.138+0530 I/CAPI_APPFW_APPLICATION(24780): app_main.c: app_efl_exit(145) > app_efl_exit
06-12 05:22:28.138+0530 E/TBM_BACKEND(24780): tbm_bufmgr_sprd7727.c: tbm_sprd7727_bo_free(671) > [31m[data-provider-slave][libtbm-sprd7727:24780] error tbm_sprd7727_bo_free:671
06-12 05:22:28.138+0530 E/TBM_BACKEND(24780): [0m
06-12 05:22:28.188+0530 I/AUL_PAD (  499): sigchild.h: __launchpad_sig_child(142) > dead_pid = 24780 pgid = 24780
06-12 05:22:28.188+0530 I/AUL_PAD (  499): sigchild.h: __sigchild_action(123) > dead_pid(24780)
06-12 05:22:28.188+0530 I/AUL_PAD (  499): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-12 05:22:28.188+0530 I/AUL_PAD (  499): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-12 05:22:28.188+0530 I/AUL_AMD (  455): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 24780
06-12 05:22:28.188+0530 I/Tizen::System( 1126): (246) > Terminated app [com.samsung.data-provider-slave]
06-12 05:22:28.188+0530 I/Tizen::Io( 1126): (729) > Entry not found
06-12 05:22:28.188+0530 I/Tizen::App( 1055): (243) > App[com.samsung.data-provider-slave] pid[24780] terminate event is forwarded
06-12 05:22:28.188+0530 I/Tizen::System( 1055): (256) > osp.accessorymanager.service provider is found.
06-12 05:22:28.188+0530 I/Tizen::System( 1055): (196) > Accessory Owner is removed [com.samsung.data-provider-slave, 24780, ]
06-12 05:22:28.188+0530 I/Tizen::System( 1055): (256) > osp.system.service provider is found.
06-12 05:22:28.188+0530 I/Tizen::App( 1055): (506) > TerminatedApp(com.samsung.data-provider-slave)
06-12 05:22:28.188+0530 I/Tizen::App( 1055): (512) > Not registered pid(24780)
06-12 05:22:28.188+0530 I/Tizen::App( 1055): (782) > Finished invoking application event listener for com.samsung.data-provider-slave, 24780.
06-12 05:22:28.198+0530 I/Tizen::System( 1126): (157) > change brightness system value.
06-12 05:22:28.198+0530 I/Tizen::App( 1126): (782) > Finished invoking application event listener for com.samsung.data-provider-slave, 24780.
06-12 05:22:30.028+0530 W/AUL_AMD (  455): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
06-12 05:22:37.108+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-12 05:22:37.108+0530 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-12 05:22:37.148+0530 W/CRASH_MANAGER(25704): worker.c: worker_job(1236) > 112547163616d143406675
