S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: watchdog
PID: 22577
Date: 2015-08-08 04:09:08+0530
Executable File Path: /opt/usr/apps/org.tizen.watchdog/bin/watchdog
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 22577, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00005831
r2   = 0x00000006, r3   = 0x00005831
r4   = 0x00000006, r5   = 0x000f5528
r6   = 0xb6cf2bec, r7   = 0x0000010c
r8   = 0xb64ea000, r9   = 0x00000002
r10  = 0x00000076, fp   = 0xbe82c638
ip   = 0xb64ea4c0, sp   = 0xbe82bf00
lr   = 0xb6bfd6bc, pc   = 0xb6bf99e8
cpsr = 0x20000010

Memory Information
MemTotal:   730748 KB
MemFree:     31292 KB
Buffers:     35060 KB
Cached:     192116 KB
VmPeak:      72940 KB
VmSize:      72936 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16064 KB
VmRSS:       16060 KB
VmData:      21928 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29988 KB
VmPTE:          58 KB
VmSwap:        296 KB

Threads Information
Threads: 4
PID = 22577 TID = 22577
22577 22579 22580 22583 

Maps Information
b2c85000 b3484000 rw-p [stack:22583]
b3499000 b349a000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b34a2000 b34b9000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3660000 b3664000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b366e000 b3e6d000 rw-p [stack:22579]
b3e6d000 b3fb4000 r-xp /usr/lib/driver/libMali.so
b3fc1000 b408b000 r-xp /usr/lib/libCOREGL.so.4.0
b409c000 b409f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b40a7000 b40aa000 r-xp /usr/lib/libEGL.so.1.4
b40b2000 b40c0000 r-xp /usr/lib/libGLESv2.so.2.0
b40c9000 b4119000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b435f000 b4373000 r-xp /usr/lib/libnetwork.so.0.0.0
b437b000 b4384000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.26
b438c000 b438e000 r-xp /usr/lib/libdevice_info.so.0.0.2
b4396000 b4398000 r-xp /usr/lib/libcryptsvc.so.0.0.2
b43a0000 b43bc000 r-xp /usr/lib/libdrm-service-core-tizen.so.0.3.9
b43d3000 b43da000 r-xp /usr/lib/libminizip.so.1.0.0
b43e2000 b43e4000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b43ec000 b43f3000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b43fc000 b4418000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4421000 b4427000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b442f000 b4440000 r-xp /lib/libnsl-2.13.so
b444b000 b4453000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.55
b445b000 b445c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b4464000 b447f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4487000 b448c000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b4494000 b449c000 r-xp /usr/lib/libpims-ipc.so.0.1.18
b44a4000 b4505000 r-xp /usr/lib/libasound.so.2.0.0
b450f000 b4513000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b451b000 b451e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b4527000 b4529000 r-xp /usr/lib/libemail-network.so.1.1.0
b4531000 b4535000 r-xp /usr/lib/libstorage.so.0.1
b453d000 b4573000 r-xp /usr/lib/libgmime-2.6.so.0.600.15
b458e000 b46cd000 r-xp /usr/lib/libicui18n.so.51.1
b46dd000 b46e1000 r-xp /usr/lib/libbadge.so.0.0.1
b46e9000 b46f0000 r-xp /usr/lib/libfeedback.so.0.1.4
b4704000 b4710000 r-xp /usr/lib/libalarm.so.0.0.0
b4719000 b472c000 r-xp /usr/lib/libaccounts-svc.so.0.2.97
b4734000 b4778000 r-xp /usr/lib/libcontacts-service2.so.0.12.54
b4783000 b482d000 r-xp /usr/lib/libuw-imap-toolkit.so.0.0.0
b483a000 b483e000 r-xp /usr/lib/libss-client.so.1.0.0
b4846000 b484f000 r-xp /usr/lib/libmdm-common.so.1.0.45
b4857000 b489f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b48a0000 b48a6000 r-xp /usr/lib/libjson.so.0.1.0
b48ae000 b48b6000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b48c5000 b48c7000 r-xp /usr/lib/libiniparser.so.0
b48d1000 b48e7000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b4915000 b4918000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4920000 b4936000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b493e000 b4942000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b494b000 b498e000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b4996000 b49a3000 r-xp /usr/lib/libemail-common-use.so.1.1.0
b49ab000 b4a17000 r-xp /usr/lib/libemail-core.so.1.1.0
b4a28000 b4a64000 r-xp /usr/lib/libemail-storage.so.1.1.0
b4a6d000 b4a76000 r-xp /usr/lib/libemail-ipc.so.1.1.0
b4a7e000 b4a80000 r-xp /usr/lib/libdri2.so.0.0.0
b4a88000 b4a8f000 r-xp /usr/lib/libdrm.so.2.4.0
b4a98000 b4a9c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4aa5000 b4ab8000 r-xp /usr/lib/libmdm.so.1.0.88
b4ac0000 b4ac6000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b4acf000 b4ad9000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b4ae5000 b4aed000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4af5000 b4af7000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
b4aff000 b4b36000 r-xp /usr/lib/libpulse.so.0.16.2
b4b3f000 b4b44000 r-xp /usr/lib/libmmfsession.so.0.0.0
b4b4c000 b4b61000 r-xp /usr/lib/libmmfsound.so.0.1.0
b4b69000 b4b6c000 r-xp /usr/lib/libmm_ta.so.0.0.0
b4b74000 b4b7d000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b4b85000 b4b92000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b4b9b000 b4ba4000 r-xp /usr/lib/libcom-core.so.0.0.1
b4bac000 b4bbc000 r-xp /usr/lib/libemail-api.so.1.1.0
b4bc4000 b4bcb000 r-xp /usr/lib/libtbm.so.1.0.0
b4bd3000 b4c6e000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b4c7a000 b4c7f000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4c87000 b4cd8000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b4ce6000 b4cea000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.3
b4cf2000 b4cf4000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4cfc000 b4d09000 r-xp /usr/lib/libnotification.so.0.1.0
b4d11000 b4d21000 r-xp /usr/lib/libcapi-media-camera.so.0.1.71
b4d2b000 b4d35000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4d3e000 b4d44000 r-xp /opt/usr/apps/org.tizen.watchdog/bin/watchdog
b4d4f000 b4d59000 r-xp /lib/libnss_files-2.13.so
b4d62000 b4d74000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4d7c000 b4d92000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4d9a000 b4e68000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4e7f000 b4ea3000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4eac000 b4eb2000 r-xp /usr/lib/libappsvc.so.0.1.0
b4eba000 b4ec8000 r-xp /usr/lib/libail.so.0.1.0
b4ed0000 b4ed2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4edb000 b4ee0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4ee8000 b4eea000 r-xp /usr/lib/libcapi-messaging-email.so.0.1.24
b4ef3000 b4ef4000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4efd000 b4f01000 r-xp /usr/lib/libogg.so.0.7.1
b4f09000 b4f2b000 r-xp /usr/lib/libvorbis.so.0.4.3
b4f33000 b5017000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b502b000 b505c000 r-xp /usr/lib/libFLAC.so.8.2.0
b59f6000 b5a8a000 r-xp /usr/lib/libstdc++.so.6.0.16
b5a9d000 b5a9f000 r-xp /usr/lib/libXau.so.6.0.0
b5aa7000 b5ab1000 r-xp /usr/lib/libspdy.so.0.0.0
b5aba000 b5b06000 r-xp /usr/lib/libssl.so.1.0.0
b5b13000 b5b41000 r-xp /usr/lib/libidn.so.11.5.44
b5b49000 b5b53000 r-xp /usr/lib/libcares.so.2.1.0
b5b5b000 b5b7c000 r-xp /usr/lib/libexif.so.12.3.3
b5b8f000 b5bd4000 r-xp /usr/lib/libsndfile.so.1.0.25
b5be2000 b5bf8000 r-xp /lib/libexpat.so.1.5.2
b5c01000 b5ce6000 r-xp /usr/lib/libicuuc.so.51.1
b5cfb000 b5d2f000 r-xp /usr/lib/libicule.so.51.1
b5d38000 b5d4b000 r-xp /usr/lib/libxcb.so.1.1.0
b5d53000 b5d90000 r-xp /usr/lib/libcurl.so.4.3.0
b5d99000 b5da2000 r-xp /usr/lib/libethumb.so.1.7.99
b5dab000 b5dad000 r-xp /usr/lib/libctxdata.so.0.0.0
b5db5000 b5dc2000 r-xp /usr/lib/libremix.so.0.0.0
b5dca000 b5dcb000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5dd3000 b5dea000 r-xp /usr/lib/liblua-5.1.so
b5df3000 b5dfa000 r-xp /usr/lib/libembryo.so.1.7.99
b5e02000 b5e25000 r-xp /usr/lib/libjpeg.so.8.0.2
b5e3d000 b5e93000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5ea0000 b5ef3000 r-xp /usr/lib/libfreetype.so.6.8.1
b5efe000 b5f26000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5f27000 b5f6d000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5f76000 b5f89000 r-xp /usr/lib/libfribidi.so.0.3.1
b5f91000 b5f94000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5f9c000 b5fa0000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5fa8000 b5fad000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5fb6000 b5fc0000 r-xp /usr/lib/libXext.so.6.4.0
b5fc8000 b60a9000 r-xp /usr/lib/libX11.so.6.3.0
b60b4000 b60b7000 r-xp /usr/lib/libXtst.so.6.1.0
b60bf000 b60c5000 r-xp /usr/lib/libXrender.so.1.3.0
b60cd000 b60d2000 r-xp /usr/lib/libXrandr.so.2.2.0
b60da000 b60db000 r-xp /usr/lib/libXinerama.so.1.0.0
b60e4000 b60ec000 r-xp /usr/lib/libXi.so.6.1.0
b60ed000 b60f0000 r-xp /usr/lib/libXfixes.so.3.1.0
b60f8000 b60fa000 r-xp /usr/lib/libXgesture.so.7.0.0
b6102000 b6104000 r-xp /usr/lib/libXcomposite.so.1.0.0
b610c000 b610d000 r-xp /usr/lib/libXdamage.so.1.1.0
b6116000 b611c000 r-xp /usr/lib/libXcursor.so.1.0.2
b6125000 b613e000 r-xp /usr/lib/libecore_con.so.1.7.99
b6148000 b614e000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6156000 b615e000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6166000 b616f000 r-xp /usr/lib/libedbus.so.1.7.99
b6177000 b61d4000 r-xp /usr/lib/libedje.so.1.7.99
b61dd000 b61ee000 r-xp /usr/lib/libecore_input.so.1.7.99
b61f6000 b61fb000 r-xp /usr/lib/libecore_file.so.1.7.99
b6203000 b621c000 r-xp /usr/lib/libeet.so.1.7.99
b622d000 b6231000 r-xp /usr/lib/libappcore-common.so.1.1
b6239000 b6300000 r-xp /usr/lib/libevas.so.1.7.99
b6325000 b6346000 r-xp /usr/lib/libecore_evas.so.1.7.99
b634f000 b637e000 r-xp /usr/lib/libecore_x.so.1.7.99
b6388000 b64bf000 r-xp /usr/lib/libelementary.so.1.7.99
b64d5000 b64d6000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b64de000 b64e2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b64ed000 b64f0000 r-xp /lib/libgpg-error.so.0.5.0
b64f8000 b6550000 r-xp /usr/lib/libgcrypt.so.11.5.3
b655a000 b6586000 r-xp /usr/lib/libsystemd.so.0.0.1
b658f000 b6591000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b659a000 b6665000 r-xp /usr/lib/libxml2.so.2.7.8
b6673000 b6683000 r-xp /lib/libresolv-2.13.so
b6687000 b669d000 r-xp /lib/libz.so.1.2.5
b66a5000 b66a7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66af000 b66b4000 r-xp /usr/lib/libffi.so.5.0.10
b66bd000 b66be000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b66c6000 b66c9000 r-xp /lib/libattr.so.1.1.0
b66d1000 b66d4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b66dc000 b66e3000 r-xp /usr/lib/libvconf.so.0.2.45
b66ec000 b6894000 r-xp /usr/lib/libcrypto.so.1.0.0
b68b5000 b68cb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b68d3000 b693c000 r-xp /lib/libm-2.13.so
b6945000 b6985000 r-xp /usr/lib/libeina.so.1.7.99
b698e000 b69c2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b69cb000 b6a9f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6aab000 b6ab0000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6ab9000 b6abf000 r-xp /lib/librt-2.13.so
b6ac8000 b6acf000 r-xp /lib/libcrypt-2.13.so
b6aff000 b6b02000 r-xp /lib/libcap.so.2.21
b6b0a000 b6b0c000 r-xp /usr/lib/libiri.so
b6b14000 b6b33000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b3b000 b6b51000 r-xp /usr/lib/libecore.so.1.7.99
b6b67000 b6b6c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b75000 b6b8c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6b95000 b6ba0000 r-xp /lib/libunwind.so.8.0.1
b6bcd000 b6ce8000 r-xp /lib/libc-2.13.so
b6cf6000 b6cfe000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d06000 b6d30000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6d39000 b6d3c000 r-xp /usr/lib/libbundle.so.0.1.22
b6d44000 b6d46000 r-xp /lib/libdl-2.13.so
b6d4f000 b6d52000 r-xp /usr/lib/libsmack.so.1.0.0
b6d5a000 b6e2a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6e2b000 b6e90000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e9a000 b6eac000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eb4000 b6ec8000 r-xp /lib/libpthread-2.13.so
b6ed3000 b6ed5000 r-xp /usr/lib/libdlog.so.0.0.0
b6edd000 b6ee8000 r-xp /usr/lib/libaul.so.0.1.0
b6ef6000 b6ef9000 rw-p [stack:22580]
b6efa000 b6efd000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f07000 b6f0b000 r-xp /usr/lib/libsys-assert.so
b6f14000 b6f31000 r-xp /lib/ld-2.13.so
b6f3a000 b6f3f000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b8d97000 b8dc1000 rw-p [heap]
b8dc1000 b8fe6000 rw-p [heap]
be80d000 be82e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22577)
Call Stack Count: 24
 0: gsignal + 0x3c (0xb6bf99e8) [/lib/libc.so.6] + 0x2c9e8
 1: abort + 0x1ac (0xb6bfd6bc) [/lib/libc.so.6] + 0x306bc
 2: (0xb6c2cee4) [/lib/libc.so.6] + 0x5fee4
 3: (0xb6c378e4) [/lib/libc.so.6] + 0x6a8e4
 4: _app_resume_cb + 0x3e (0xb4d42f5b) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x4f5b
 5: (0xb64dfc89) [/usr/lib/libcapi-appfw-application.so.0] + 0x1c89
 6: (0xb6efbeb1) [/usr/lib/libappcore-efl.so.1] + 0x1eb1
 7: (0xb622ed43) [/usr/lib/libappcore-common.so.1] + 0x1d43
 8: (0xb6ee0eb1) [/usr/lib/libaul.so.0] + 0x3eb1
 9: (0xb6ee1791) [/usr/lib/libaul.so.0] + 0x4791
10: (0xb6d8db9f) [/usr/lib/libglib-2.0.so.0] + 0x33b9f
11: g_main_context_dispatch + 0xbc (0xb6d8f379) [/usr/lib/libglib-2.0.so.0] + 0x35379
12: (0xb6b4a807) [/usr/lib/libecore.so.1] + 0xf807
13: (0xb6b45967) [/usr/lib/libecore.so.1] + 0xa967
14: (0xb6b462ed) [/usr/lib/libecore.so.1] + 0xb2ed
15: ecore_main_loop_begin + 0x30 (0xb6b46691) [/usr/lib/libecore.so.1] + 0xb691
16: appcore_efl_main + 0x17e (0xb6efc387) [/usr/lib/libappcore-efl.so.1] + 0x2387
17: ui_app_main + 0xb0 (0xb64e0499) [/usr/lib/libcapi-appfw-application.so.0] + 0x2499
18: app_run + 0x4e (0xb4d42e8f) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x4e8f
19: main + 0x26 (0xb4d43237) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x5237
20: _main_view_timer_cb + 0x46 (0xb6f3cdc7) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x2dc7
21: (0xb6f3bd8f) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x1d8f
22: __libc_start_main + 0x114 (0xb6be482c) [/lib/libc.so.6] + 0x1782c
23: (0xb6f3c0d4) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x20d4
End of Call Stack

Package Information
Package Name: org.tizen.watchdog
Package ID : org.tizen.watchdog
Version: 1.0.0
Package Type: rpm
App Name: WatchDog
App ID: org.tizen.watchdog
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
date_display(585) > "Noti Icon : 343 595 5 28 25"
08-08 04:08:54.766+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 375 623 5 28 25"
08-08 04:08:54.766+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 651 5 28 25"
08-08 04:08:54.766+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
08-08 04:08:54.766+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 707 5 28 25"
08-08 04:08:54.956+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:08:55.996+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:08:55.996+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:08:55.996+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:08:55.996+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:08:55.996+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:08:55.996+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:08:55.996+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:08:55.996+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:08:55.996+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:08:55.996+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:08:55.996+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:08:56.386+0530 E/VCONF   (  939): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
08-08 04:08:56.386+0530 E/VCONF   (  939): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
08-08 04:08:56.386+0530 E/VCONF   (  939): vconf.c: vconf_get_int(2379) > vconf_get_int(939) : file/private/wifi/always_allow_scanning error
08-08 04:08:56.386+0530 E/VCONF   (  939): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
08-08 04:08:56.386+0530 E/VCONF   (  939): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
08-08 04:08:56.386+0530 E/VCONF   (  939): vconf.c: vconf_get_int(2379) > vconf_get_int(939) : file/private/wifi/always_allow_scanning error
08-08 04:08:56.406+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-08 04:08:56.406+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-08 04:08:57.056+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:08:57.236+0530 I/Tizen::Net::Wifi( 1082): (928) > The background scan result updated.
08-08 04:08:57.236+0530 I/Tizen::Net::Wifi( 1082): (934) > Fire event [WIFI_EVENT_SCAN_COMPLETED]
08-08 04:08:57.326+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-08 04:08:57.336+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-08 04:08:57.716+0530 E/PKGMGR_SERVER(22402): pkgmgr-server.c: main(1608) > server start
08-08 04:08:57.846+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-08 04:08:57.846+0530 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-08 04:08:57.906+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:08:57.916+0530 I/indicator(  508): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 604"
08-08 04:08:57.936+0530 I/AUL_PAD (  504): sigchild.h: __launchpad_sig_child(142) > dead_pid = 21457 pgid = 21457
08-08 04:08:57.936+0530 I/AUL_PAD (  504): sigchild.h: __sigchild_action(123) > dead_pid(21457)
08-08 04:08:57.936+0530 I/AUL_PAD (  504): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-08 04:08:57.936+0530 I/AUL_PAD (  504): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-08 04:08:57.936+0530 I/AUL_AMD (  455): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 21457
08-08 04:08:57.936+0530 I/Tizen::System( 1053): (246) > Terminated app [org.tizen.watchdog]
08-08 04:08:57.936+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-08 04:08:57.936+0530 I/Tizen::App(  999): (243) > App[org.tizen.watchdog] pid[21457] terminate event is forwarded
08-08 04:08:57.936+0530 I/Tizen::System(  999): (256) > osp.accessorymanager.service provider is found.
08-08 04:08:57.936+0530 I/Tizen::System(  999): (196) > Accessory Owner is removed [org.tizen.watchdog, 21457, ]
08-08 04:08:57.936+0530 I/Tizen::System(  999): (256) > osp.system.service provider is found.
08-08 04:08:57.936+0530 I/Tizen::App(  999): (506) > TerminatedApp(org.tizen.watchdog)
08-08 04:08:57.936+0530 I/Tizen::App(  999): (512) > Not registered pid(21457)
08-08 04:08:57.936+0530 I/Tizen::App(  999): (782) > Finished invoking application event listener for org.tizen.watchdog, 21457.
08-08 04:08:57.936+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-08 04:08:57.936+0530 I/Tizen::App( 1053): (782) > Finished invoking application event listener for org.tizen.watchdog, 21457.
08-08 04:08:57.956+0530 W/PROCESSMGR(  343): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=604
08-08 04:08:57.976+0530 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-08 04:08:57.976+0530 E/cluster-home(  604): homescreen-main.cpp: app_resume(422) >  app resume
08-08 04:08:57.986+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 0
08-08 04:08:57.996+0530 I/AUL     (  455): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/data-provider-master, ret : 0
08-08 04:08:58.006+0530 I/AUL     (  455): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/data-provider-master, ret : 0
08-08 04:08:58.006+0530 E/AUL_AMD (  455): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
08-08 04:08:58.026+0530 I/Tizen::System( 1053): (259) > Active app [com.samsun], current [org.tizen.] 
08-08 04:08:58.026+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-08 04:08:58.036+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-08 04:08:58.126+0530 I/CAPI_APPFW_APPLICATION(22405): app_main.c: ui_app_main(699) > app_efl_main
08-08 04:08:58.176+0530 I/UXT     (22405): uxt_object_manager.cpp: on_initialized(287) > Initialized.
08-08 04:08:58.226+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:08:58.226+0530 I/Tizen::App(  999): (499) > LaunchedApp(com.samsung.data-provider-slave)
08-08 04:08:58.226+0530 I/Tizen::App(  999): (733) > Finished invoking application event listener for com.samsung.data-provider-slave, 22405.
08-08 04:08:58.256+0530 E/RESOURCED(  837): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 270
08-08 04:08:58.256+0530 I/Tizen::App( 1053): (733) > Finished invoking application event listener for com.samsung.data-provider-slave, 22405.
08-08 04:08:58.266+0530 I/Tizen::System( 1120): (101) > Active App is com.samsung.homescreen. GetApp id ACL111OMWW.AclService
08-08 04:08:58.286+0530 I/CAPI_APPFW_APPLICATION(22405): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
08-08 04:08:58.316+0530 I/EFL-ASSIST(22405): efl_assist_theme_font.c: ea_theme_font_table_new(393) > font table (b8e2dae8) from (/usr/share/themes/FontInfoTable.xml) is created
08-08 04:08:58.316+0530 E/TIZEN_N_SYSTEM_SETTINGS(22405): system_settings.c: system_settings_set_changed_cb(541) > b4cfb1fd
08-08 04:08:58.316+0530 E/TIZEN_N_SYSTEM_SETTINGS(22405): system_settings_vconf.c: system_setting_vconf_set_changed_cb(263) > [system_setting_vconf_set_changed_cb] vconf_notify_key_changed registered : db/setting/accessibility/font_size --- callback ptr : b4cf9dfd
08-08 04:08:58.316+0530 E/EFL     (22405): evas_main<22405> evas_font_dir.c:1515 evas_font_reinit() ENTER:: evas_font_reinit
08-08 04:08:58.336+0530 E/EFL     (22405): evas_main<22405> evas_font_dir.c:1526 evas_font_reinit() DONE:: evas_font_reinit
08-08 04:08:58.356+0530 I/EFL-ASSIST(22405): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b8e3e370) from (/opt/usr/share/data-provider-slave/theme/color/com.samsung.data-provider-slave_ChangeableColorInfo.xml) is created
08-08 04:08:58.356+0530 E/EFL-ASSIST(22405): efl_assist_theme_color.cpp: ea_theme_colors_set(868) > cannot get color table data
08-08 04:08:58.356+0530 I/CAPI_APPFW_APPLICATION(22405): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
08-08 04:08:58.376+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:08:58.406+0530 I/APP_CORE(22405): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
08-08 04:08:58.406+0530 I/APP_CORE(22405): appcore-efl.c: __do_app(511) > [APP 22405] Initial Launching, call the resume_cb
08-08 04:08:58.406+0530 I/CAPI_APPFW_APPLICATION(22405): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
08-08 04:08:58.526+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack_append(874) > "[icon_box_pack_append] 377!"
08-08 04:08:58.526+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-08 04:08:58.526+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-08 04:08:58.536+0530 E/CAPI_LOCATION_MANAGER(  939): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
08-08 04:08:58.536+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-08 04:08:58.536+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 390 0 56 36"
08-08 04:08:58.536+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-08 04:08:58.556+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-08 04:08:58.556+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 1e1ce40 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-08 04:08:58.556+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 0 0 0 0"
08-08 04:08:58.556+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-08 04:08:58.556+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 359 5 28 25"
08-08 04:08:58.556+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-08 04:08:58.556+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-08 04:08:58.556+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-08 04:08:58.556+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 710 0 56 36"
08-08 04:08:58.556+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 567 5 28 25"
08-08 04:08:58.556+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 375 595 5 28 25"
08-08 04:08:58.556+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 623 5 28 25"
08-08 04:08:58.556+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-08 04:08:58.556+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 679 5 28 25"
08-08 04:08:58.596+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:08:58.596+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:08:58.596+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:08:58.596+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:08:58.596+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:08:58.596+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:08:58.596+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:08:58.596+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:08:58.596+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:08:58.596+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:08:58.816+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_create(363) > New handle created[0xb8e8d040]
08-08 04:08:58.816+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: __connection_set_type_changed_callback(146) > Successfully registered(1)
08-08 04:08:58.816+0530 E/weather-common(22405): dbf-engine-db.c: dbf_engine_db_initialize(66) > [0;40;31mp_db_handle is NULL[0;m
08-08 04:08:58.846+0530 E/cluster-home(  604): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
08-08 04:08:58.846+0530 E/cluster-home(  604): cluster-data-list.cpp: UpdateCustomDBox(1485) >  Invalid box size: 65535
08-08 04:08:58.846+0530 W/cluster-home(  604): cluster-data-provider.cpp: DBoxEventUpdated(1657) >  Can not update dynamicbox
08-08 04:08:58.866+0530 E/weather-live(22405): main.c: dynamicbox_resize(1813) > [0;40;31minfo->first_create : 0[0;m
08-08 04:08:58.896+0530 E/EFL     (22405): evas_main<22405> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
08-08 04:08:58.896+0530 E/EFL     (22405): evas_main<22405> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
08-08 04:08:58.976+0530 E/weather-live(22405): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
08-08 04:08:59.126+0530 E/weather-live(22405): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
08-08 04:08:59.126+0530 E/weather-live(22405): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
08-08 04:08:59.166+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_create(363) > New handle created[0xb8ff7528]
08-08 04:08:59.166+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_get_type(412) > Connected Network = 2
08-08 04:08:59.166+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_destroy(379) > Destroy handle: 0xb8ff7528
08-08 04:08:59.176+0530 E/weather-common(22405): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
08-08 04:08:59.196+0530 E/weather-common(22405): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sun[0;m
08-08 04:08:59.216+0530 E/weather-common(22405): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Mon[0;m
08-08 04:08:59.216+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-08 04:08:59.216+0530 W/AUL_AMD (  455): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
08-08 04:08:59.236+0530 E/weather-common(22405): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
08-08 04:08:59.266+0530 E/weather-live(22405): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
08-08 04:08:59.276+0530 E/weather-live(22405): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
08-08 04:08:59.276+0530 E/weather-live(22405): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
08-08 04:08:59.296+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_create(363) > New handle created[0xb8f12ac8]
08-08 04:08:59.296+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_get_type(412) > Connected Network = 2
08-08 04:08:59.296+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_destroy(379) > Destroy handle: 0xb8f12ac8
08-08 04:08:59.306+0530 E/weather-common(22405): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
08-08 04:08:59.326+0530 E/weather-common(22405): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sun[0;m
08-08 04:08:59.346+0530 E/weather-common(22405): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Mon[0;m
08-08 04:08:59.356+0530 E/weather-common(22405): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
08-08 04:08:59.386+0530 E/weather-live(22405): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
08-08 04:08:59.396+0530 E/weather-live(22405): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/nocity_msg, text : ) [return][0;m
08-08 04:08:59.396+0530 E/weather-live(22405): live-dbf-common.c: live_weather_edje_part_text_set(208) > [0;40;31mFaild : edje_object_part_object_get (part : weather/title, text : ) [return][0;m
08-08 04:08:59.436+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_create(363) > New handle created[0xb9072108]
08-08 04:08:59.436+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_get_type(412) > Connected Network = 2
08-08 04:08:59.436+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_destroy(379) > Destroy handle: 0xb9072108
08-08 04:08:59.446+0530 E/weather-common(22405): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sat[0;m
08-08 04:08:59.476+0530 E/weather-common(22405): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Sun[0;m
08-08 04:08:59.506+0530 E/weather-common(22405): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Mon[0;m
08-08 04:08:59.526+0530 E/weather-common(22405): dbf-engine-util.c: dbf_util_get_day_text(1774) > [0;40;31mtext_day_org:Tue[0;m
08-08 04:08:59.676+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:08:59.686+0530 E/cluster-home(  604): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
08-08 04:08:59.686+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_create(363) > New handle created[0xb8ee4670]
08-08 04:08:59.686+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_get_type(412) > Connected Network = 2
08-08 04:08:59.686+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_destroy(379) > Destroy handle: 0xb8ee4670
08-08 04:08:59.686+0530 E/weather-live(22405): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
08-08 04:08:59.686+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_create(363) > New handle created[0xb8ebe8c0]
08-08 04:08:59.686+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_get_type(412) > Connected Network = 2
08-08 04:08:59.686+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_destroy(379) > Destroy handle: 0xb8ebe8c0
08-08 04:08:59.696+0530 E/weather-live(22405): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
08-08 04:08:59.696+0530 E/cluster-home(  604): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
08-08 04:08:59.696+0530 E/cluster-home(  604): cluster-data-provider.cpp: EventPixmapAcquired(2075) >  Release depreacted pixmap [27263072]
08-08 04:08:59.726+0530 E/weather-live(22405): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
08-08 04:08:59.746+0530 E/weather-live(22405): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
08-08 04:08:59.766+0530 E/weather-common(22405): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
08-08 04:08:59.766+0530 E/weather-common(22405): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
08-08 04:08:59.996+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_create(363) > New handle created[0xb905f488]
08-08 04:08:59.996+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'L'
08-08 04:08:59.996+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_get_type(412) > Connected Network = 2
08-08 04:08:59.996+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_destroy(379) > Destroy handle: 0xb905f488
08-08 04:08:59.996+0530 E/weather-live(22405): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
08-08 04:08:59.996+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_create(363) > New handle created[0xb90008e8]
08-08 04:08:59.996+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_get_type(412) > Connected Network = 2
08-08 04:08:59.996+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_destroy(379) > Destroy handle: 0xb90008e8
08-08 04:08:59.996+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'F'
08-08 04:08:59.996+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
08-08 04:08:59.996+0530 I/Tizen::Base::Runtime( 1120): (251) > The timer is not started.
08-08 04:08:59.996+0530 I/Tizen::System( 1120): (85) > Current Epoch is 35798725508.
08-08 04:08:59.996+0530 I/Tizen::System( 1120): (89) > Calendar time is sec:0, min:39, hour:22, day:7, mon:7, year:115, wday5, year:218, dst:0
08-08 04:08:59.996+0530 I/Tizen::System( 1120): (99) > Current time zone is Asia/Kolkata, 330, 60
08-08 04:08:59.996+0530 I/Tizen::System( 1120): (103) > Original Time is 2015 8/7, 22:39:0:10
08-08 04:08:59.996+0530 I/Tizen::System( 1120): (123) > Current Time is 2015 8/8, 4:9:0
08-08 04:08:59.996+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 28259990 milliseconds from now
08-08 04:09:00.016+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(true)
08-08 04:09:00.016+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
08-08 04:09:00.016+0530 I/Tizen::System( 1120): (85) > Current Epoch is 1438987140.
08-08 04:09:00.016+0530 I/Tizen::System( 1120): (89) > Calendar time is sec:0, min:39, hour:22, day:7, mon:7, year:115, wday5, year:218, dst:0
08-08 04:09:00.016+0530 I/Tizen::System( 1120): (99) > Current time zone is Asia/Kolkata, 330, 60
08-08 04:09:00.016+0530 I/Tizen::System( 1120): (103) > Original Time is 2015 8/7, 22:39:0:22
08-08 04:09:00.016+0530 I/Tizen::System( 1120): (123) > Current Time is 2015 8/8, 4:9:0
08-08 04:09:00.016+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59978 milliseconds from now
08-08 04:09:00.016+0530 E/weather-live(22405): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
08-08 04:09:00.016+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-08 04:09:00.016+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(false)
08-08 04:09:00.036+0530 E/weather-live(22405): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
08-08 04:09:00.056+0530 E/weather-live(22405): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
08-08 04:09:00.076+0530 E/weather-common(22405): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_mylocation(2936) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
08-08 04:09:00.076+0530 E/weather-common(22405): weather-engine-db.c: dbf_weather_engine_db_get_weather_info(452) > [0;40;31mFailed:: sqlite3_step failed , rc = 101, index:-1[0;m
08-08 04:09:00.086+0530 E/cluster-home(  604): cluster-data-list.cpp: GetDBoxID(1096) >  found id[1]
08-08 04:09:00.356+0530 I/MALI    (  604): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb0635910] swap changed from async to sync
08-08 04:09:00.386+0530 E/PKGMGR_SERVER(22402): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
08-08 04:09:00.386+0530 E/PKGMGR_SERVER(22402): pkgmgr-server.c: main(1704) > package manager server terminated.
08-08 04:09:00.736+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:09:00.736+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:09:00.736+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:09:00.736+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:09:00.736+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:09:00.736+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:09:00.736+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:09:00.736+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:09:00.736+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:09:00.736+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:09:00.736+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:09:01.776+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:09:02.056+0530 E/PKGMGR_SERVER(22506): pkgmgr-server.c: main(1608) > server start
08-08 04:09:02.116+0530 E/PKGMGR  (22506): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.watchdog]
08-08 04:09:02.116+0530 E/PKGMGR_SERVER(22506): pkgmgr-server.c: __get_type_from_msg(289) > [0;31m[__get_type_from_msg(): 289](pkgtype == NULL) pkgtype is null for org.tizen.watchdog 
08-08 04:09:02.116+0530 E/PKGMGR_SERVER(22506): [0;m
08-08 04:09:02.286+0530 I/Tizen::App( 1053): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: start, val: update
08-08 04:09:02.286+0530 I/Tizen::App( 1053): (1584) > Package = [org.tizen.watchdog], Key = [start], Value = [update], install = [96]
08-08 04:09:02.286+0530 I/Tizen::App( 1120): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: start, val: update
08-08 04:09:02.286+0530 I/Tizen::App( 1120): (1584) > Package = [org.tizen.watchdog], Key = [start], Value = [update], install = [96]
08-08 04:09:02.286+0530 I/Tizen::App(  999): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: start, val: update
08-08 04:09:02.286+0530 I/Tizen::App(  999): (1584) > Package = [org.tizen.watchdog], Key = [start], Value = [update], install = [1]
08-08 04:09:02.296+0530 W/AUL_AMD (  455): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
08-08 04:09:02.306+0530 I/Tizen::App( 1053): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: install_percent, val: 30
08-08 04:09:02.306+0530 I/Tizen::App( 1053): (119) > InstallationInProgress [30]
08-08 04:09:02.306+0530 I/Tizen::App( 1053): (1584) > Package = [org.tizen.watchdog], Key = [install_percent], Value = [30], install = [96]
08-08 04:09:02.306+0530 I/Tizen::App(  999): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: install_percent, val: 30
08-08 04:09:02.306+0530 I/Tizen::App(  999): (119) > InstallationInProgress [30]
08-08 04:09:02.306+0530 I/Tizen::App(  999): (1584) > Package = [org.tizen.watchdog], Key = [install_percent], Value = [30], install = [1]
08-08 04:09:02.316+0530 I/Tizen::App( 1120): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: install_percent, val: 30
08-08 04:09:02.316+0530 I/Tizen::App( 1120): (119) > InstallationInProgress [30]
08-08 04:09:02.316+0530 I/Tizen::App( 1120): (1584) > Package = [org.tizen.watchdog], Key = [install_percent], Value = [30], install = [96]
08-08 04:09:02.806+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:09:02.806+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:09:02.806+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:09:02.806+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:09:02.806+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:09:02.806+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:09:02.806+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:09:02.806+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:09:02.806+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:09:02.806+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:09:02.816+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:09:03.156+0530 E/PKGMGR_CERT(22508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
08-08 04:09:03.156+0530 E/PKGMGR_CERT(22508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 86
08-08 04:09:03.166+0530 E/PKGMGR_CERT(22508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 86
08-08 04:09:03.166+0530 E/PKGMGR_CERT(22508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 55 1
08-08 04:09:03.166+0530 E/PKGMGR_CERT(22508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 56 1
08-08 04:09:03.166+0530 E/PKGMGR_CERT(22508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 57 1
08-08 04:09:03.166+0530 I/Tizen::App( 1053): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: install_percent, val: 60
08-08 04:09:03.166+0530 E/PKGMGR_CERT(22508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 58 1
08-08 04:09:03.166+0530 I/Tizen::App( 1053): (119) > InstallationInProgress [60]
08-08 04:09:03.166+0530 I/Tizen::App( 1053): (1584) > Package = [org.tizen.watchdog], Key = [install_percent], Value = [60], install = [96]
08-08 04:09:03.166+0530 I/Tizen::App(  999): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: install_percent, val: 60
08-08 04:09:03.166+0530 I/Tizen::App(  999): (119) > InstallationInProgress [60]
08-08 04:09:03.166+0530 I/Tizen::App(  999): (1584) > Package = [org.tizen.watchdog], Key = [install_percent], Value = [60], install = [1]
08-08 04:09:03.166+0530 I/Tizen::App( 1120): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: install_percent, val: 60
08-08 04:09:03.166+0530 I/Tizen::App( 1120): (119) > InstallationInProgress [60]
08-08 04:09:03.166+0530 I/Tizen::App( 1120): (1584) > Package = [org.tizen.watchdog], Key = [install_percent], Value = [60], install = [96]
08-08 04:09:03.186+0530 E/PKGMGR_CERT(22508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
08-08 04:09:03.186+0530 E/rpm-installer(22508): coretpk-installer.c: _coretpk_installer_make_directory(1927) > mkdir failed. appdir=[/usr/apps/org.tizen.watchdog/shared], errno=[2][No such file or directory]
08-08 04:09:03.186+0530 E/rpm-installer(22508): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.watchdog/shared]
08-08 04:09:03.186+0530 E/rpm-installer(22508): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/opt/usr/apps/org.tizen.watchdog/shared/data]
08-08 04:09:03.186+0530 E/rpm-installer(22508): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1549) > skip! empty dirpath=[/usr/apps/org.tizen.watchdog/shared/res]
08-08 04:09:03.186+0530 E/rpm-installer(22508): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.watchdog/tizen-manifest.xml]
08-08 04:09:03.186+0530 E/rpm-installer(22508): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.watchdog/author-signature.xml]
08-08 04:09:03.186+0530 E/rpm-installer(22508): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/apps/org.tizen.watchdog/signature1.xml]
08-08 04:09:03.186+0530 E/rpm-installer(22508): coretpk-installer.c: _coretpk_installer_apply_file_policy(1534) > skip! empty filepath=[/usr/share/packages/org.tizen.watchdog.xml]
08-08 04:09:03.656+0530 E/rpm-installer(22508): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1099) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.watchdog/shared/data]))
08-08 04:09:03.846+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:09:04.386+0530 E/PKGMGR_SERVER(22506): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
08-08 04:09:04.886+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:09:04.886+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:09:04.886+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:09:04.886+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:09:04.886+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:09:04.886+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:09:04.886+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:09:04.886+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:09:04.886+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:09:04.886+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:09:04.886+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:09:05.006+0530 W/ProcessStats( 1575): Skipping unknown process pid 22502
08-08 04:09:05.006+0530 W/ProcessStats( 1575): Skipping unknown process pid 22504
08-08 04:09:05.006+0530 W/ProcessStats( 1575): Skipping unknown process pid 22506
08-08 04:09:05.006+0530 W/ProcessStats( 1575): Skipping unknown process pid 22508
08-08 04:09:05.846+0530 I/Tizen::App( 1053): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: install_percent, val: 100
08-08 04:09:05.846+0530 I/Tizen::App( 1053): (119) > InstallationInProgress [100]
08-08 04:09:05.846+0530 I/Tizen::App( 1053): (1584) > Package = [org.tizen.watchdog], Key = [install_percent], Value = [100], install = [96]
08-08 04:09:05.846+0530 I/Tizen::App(  999): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: install_percent, val: 100
08-08 04:09:05.846+0530 I/Tizen::App(  999): (119) > InstallationInProgress [100]
08-08 04:09:05.846+0530 I/Tizen::App(  999): (1584) > Package = [org.tizen.watchdog], Key = [install_percent], Value = [100], install = [1]
08-08 04:09:05.856+0530 I/Tizen::App( 1053): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: end, val: ok
08-08 04:09:05.856+0530 I/Tizen::App( 1053): (78) > Installation is Completed. [Package = org.tizen.watchdog]
08-08 04:09:05.856+0530 I/Tizen::App( 1053): (1584) > Package = [org.tizen.watchdog], Key = [end], Value = [ok], install = [96]
08-08 04:09:05.856+0530 I/Tizen::App(  999): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: end, val: ok
08-08 04:09:05.856+0530 I/Tizen::App(  999): (78) > Installation is Completed. [Package = org.tizen.watchdog]
08-08 04:09:05.856+0530 I/Tizen::App(  999): (663) > Enter. package(org.tizen.watchdog), installationResult(0)
08-08 04:09:05.866+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 1
08-08 04:09:05.866+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: OnClientListenCb(543) >  #Step 2
08-08 04:09:05.866+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
08-08 04:09:05.886+0530 E/PKGMGR_INFO(22508): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
08-08 04:09:05.886+0530 E/PKGMGR_INSTALLER(22508): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
08-08 04:09:05.916+0530 I/Tizen::App(  999): (1360) > package(org.tizen.watchdog), version(1.0.0), type(rpm), displayName(WatchDog), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.watchdog), storeClient(), appRootPath(/opt/usr/apps/org.tizen.watchdog)
08-08 04:09:05.946+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.watchdog]
08-08 04:09:05.946+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _GetAppIds(369) >  ##### [org.tizen.watchdog]
08-08 04:09:05.946+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _GetAppIds(373) >  END
08-08 04:09:05.946+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _DoPkgJob(452) >  #Step 3 size[1]
08-08 04:09:05.946+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _DoPkgJob(456) >  appId[org.tizen.watchdog]
08-08 04:09:05.956+0530 I/Tizen::App(  999): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.watchdog]
08-08 04:09:05.986+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:09:05.986+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: _GetAppInfo(945) >  AppId[org.tizen.watchdog] Name[WatchDog] Icon[/opt/usr/apps/org.tizen.watchdog/shared/res/camerasample.png] enable[1] system[0]
08-08 04:09:05.986+0530 E/cluster-home(  604): mainmenu-package-manager.cpp: GetAppInfo(599) >  Find a App Info AppId[org.tizen.watchdog] Name[WatchDog] Icon[/opt/usr/apps/org.tizen.watchdog/shared/res/camerasample.png] enable[1] system[0]
08-08 04:09:05.996+0530 I/Tizen::App(  999): (416) > appName = [watchdog]
08-08 04:09:05.996+0530 I/Tizen::App(  999): (509) > exe = [/opt/usr/apps/org.tizen.watchdog/bin/watchdog], displayName = [WatchDog], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
08-08 04:09:05.996+0530 E/PKGMGR_INFO(  999): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
08-08 04:09:05.996+0530 I/Tizen::App(  999): (675) > Application count(1) in this package
08-08 04:09:05.996+0530 I/Tizen::App(  999): (855) > Enter.
08-08 04:09:06.006+0530 I/Tizen::App(  999): (695) > Exit.
08-08 04:09:06.006+0530 I/Tizen::App(  999): (1584) > Package = [org.tizen.watchdog], Key = [end], Value = [ok], install = [1]
08-08 04:09:06.006+0530 I/Tizen::App(  999): (416) > appName = [watchdog]
08-08 04:09:06.006+0530 I/Tizen::App(  999): (509) > exe = [/opt/usr/apps/org.tizen.watchdog/bin/watchdog], displayName = [WatchDog], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
08-08 04:09:06.006+0530 I/Tizen::App(  999): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.watchdog.info]
08-08 04:09:06.006+0530 I/Tizen::App(  999): (131) > Enter
08-08 04:09:06.006+0530 I/Tizen::App(  999): (137) > org.tizen.watchdog does not have launch condition
08-08 04:09:06.006+0530 I/Tizen::App(  999): (898) > Exit.
08-08 04:09:06.006+0530 I/Tizen::App( 1120): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: install_percent, val: 100
08-08 04:09:06.006+0530 I/Tizen::App( 1120): (119) > InstallationInProgress [100]
08-08 04:09:06.006+0530 I/Tizen::App( 1120): (1584) > Package = [org.tizen.watchdog], Key = [install_percent], Value = [100], install = [96]
08-08 04:09:06.006+0530 I/Tizen::App( 1120): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.watchdog, key: end, val: ok
08-08 04:09:06.006+0530 I/Tizen::App( 1120): (78) > Installation is Completed. [Package = org.tizen.watchdog]
08-08 04:09:06.026+0530 I/Tizen::App( 1120): (1360) > package(org.tizen.watchdog), version(1.0.0), type(rpm), displayName(WatchDog), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.watchdog), storeClient(), appRootPath(/opt/usr/apps/org.tizen.watchdog)
08-08 04:09:06.026+0530 I/Tizen::App( 1120): (149) > app = [org.tizen.watchdog], package = [org.tizen.watchdog]
08-08 04:09:06.036+0530 I/Tizen::App( 1120): (1360) > package(org.tizen.watchdog), version(1.0.0), type(rpm), displayName(WatchDog), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.watchdog), storeClient(), appRootPath(/opt/usr/apps/org.tizen.watchdog)
08-08 04:09:06.036+0530 I/Tizen::App( 1120): (1584) > Package = [org.tizen.watchdog], Key = [end], Value = [ok], install = [96]
08-08 04:09:06.386+0530 E/PKGMGR_SERVER(22506): pkgmgr-server.c: exit_server(887) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
08-08 04:09:06.386+0530 E/PKGMGR_SERVER(22506): pkgmgr-server.c: main(1704) > package manager server terminated.
08-08 04:09:07.016+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:09:07.016+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:09:07.016+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:09:07.016+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:09:07.016+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:09:07.016+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:09:07.016+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:09:07.016+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:09:07.016+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:09:07.016+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:09:07.016+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:09:07.706+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 0
08-08 04:09:07.716+0530 I/AUL     (  455): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
08-08 04:09:07.726+0530 I/AUL     (  455): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
08-08 04:09:07.726+0530 E/AUL_AMD (  455): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
08-08 04:09:07.866+0530 I/CAPI_APPFW_APPLICATION(22577): app_main.c: ui_app_main(699) > app_efl_main
08-08 04:09:07.946+0530 E/RESOURCED(  837): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 266
08-08 04:09:07.966+0530 I/Tizen::App( 1053): (733) > Finished invoking application event listener for org.tizen.watchdog, 22577.
08-08 04:09:07.966+0530 I/Tizen::App(  999): (499) > LaunchedApp(org.tizen.watchdog)
08-08 04:09:07.966+0530 I/Tizen::App(  999): (733) > Finished invoking application event listener for org.tizen.watchdog, 22577.
08-08 04:09:07.966+0530 I/CAPI_APPFW_APPLICATION(22577): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
08-08 04:09:08.056+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:09:08.286+0530 I/CAPI_APPFW_APPLICATION(22577): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
08-08 04:09:08.296+0530 W/PROCESSMGR(  343): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=22577
08-08 04:09:08.306+0530 I/APP_CORE(22577): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
08-08 04:09:08.306+0530 I/APP_CORE(22577): appcore-efl.c: __do_app(511) > [APP 22577] Initial Launching, call the resume_cb
08-08 04:09:08.306+0530 I/CAPI_APPFW_APPLICATION(22577): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
08-08 04:09:08.336+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:09:08.356+0530 I/indicator(  508): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.watchdog, pid = 22577"
08-08 04:09:08.356+0530 I/MALI    (  604): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb0635910] swap changed from sync to async
08-08 04:09:08.396+0530 I/SECURE_STORAGE(  389): ss_server_ipc.c: SsServerComm(251) > write succeed
08-08 04:09:08.406+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:09:08.406+0530 I/Tizen::System( 1120): (101) > Active App is org.tizen.watchdog. GetApp id ACL111OMWW.AclService
08-08 04:09:08.416+0530 I/Tizen::System( 1053): (259) > Active app [org.tizen.], current [com.samsun] 
08-08 04:09:08.416+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-08 04:09:08.426+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-08 04:09:08.576+0530 I/AUL_PAD (  504): sigchild.h: __launchpad_sig_child(142) > dead_pid = 22577 pgid = 22577
08-08 04:09:08.576+0530 I/AUL_PAD (  504): sigchild.h: __sigchild_action(123) > dead_pid(22577)
08-08 04:09:08.576+0530 I/AUL_PAD (  504): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-08 04:09:08.576+0530 I/AUL_PAD (  504): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-08 04:09:08.576+0530 I/AUL_AMD (  455): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 22577
08-08 04:09:08.576+0530 I/Tizen::System( 1053): (246) > Terminated app [org.tizen.watchdog]
08-08 04:09:08.576+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-08 04:09:08.576+0530 I/Tizen::App(  999): (243) > App[org.tizen.watchdog] pid[22577] terminate event is forwarded
08-08 04:09:08.576+0530 I/Tizen::System(  999): (256) > osp.accessorymanager.service provider is found.
08-08 04:09:08.576+0530 I/Tizen::System(  999): (196) > Accessory Owner is removed [org.tizen.watchdog, 22577, ]
08-08 04:09:08.576+0530 I/Tizen::System(  999): (256) > osp.system.service provider is found.
08-08 04:09:08.576+0530 I/Tizen::App(  999): (506) > TerminatedApp(org.tizen.watchdog)
08-08 04:09:08.576+0530 I/Tizen::App(  999): (512) > Not registered pid(22577)
08-08 04:09:08.576+0530 I/Tizen::App(  999): (782) > Finished invoking application event listener for org.tizen.watchdog, 22577.
08-08 04:09:08.576+0530 W/PROCESSMGR(  343): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=604
08-08 04:09:08.586+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-08 04:09:08.586+0530 I/Tizen::App( 1053): (782) > Finished invoking application event listener for org.tizen.watchdog, 22577.
08-08 04:09:08.586+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:09:08.606+0530 I/indicator(  508): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 604"
08-08 04:09:08.636+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:09:08.646+0530 I/Tizen::System( 1120): (101) > Active App is com.samsung.homescreen. GetApp id ACL111OMWW.AclService
08-08 04:09:08.646+0530 I/Tizen::System( 1053): (259) > Active app [com.samsun], current [org.tizen.] 
08-08 04:09:08.646+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-08 04:09:08.656+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-08 04:09:08.686+0530 W/CRASH_MANAGER(22584): worker.c: worker_job(1236) > 0622577776174143898714
