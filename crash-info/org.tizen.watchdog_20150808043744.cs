S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: watchdog
PID: 24657
Date: 2015-08-08 04:37:44+0530
Executable File Path: /opt/usr/apps/org.tizen.watchdog/bin/watchdog
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 24657, uid 5000)

Register Information
r0   = 0x00000001, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000073
r4   = 0x00000000, r5   = 0x00000001
r6   = 0xbe82c598, r7   = 0x00000073
r8   = 0x0000000a, r9   = 0xb64ea4d0
r10  = 0xb4d43540, fp   = 0xbe82c58c
ip   = 0x00000000, sp   = 0xbe82b970
lr   = 0xb6c0ab7c, pc   = 0xb6c3fd64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:     52644 KB
Buffers:     27756 KB
Cached:     172416 KB
VmPeak:     339292 KB
VmSize:     339288 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23268 KB
VmRSS:       23264 KB
VmData:     262900 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       30960 KB
VmPTE:         144 KB
VmSwap:        272 KB

Threads Information
Threads: 33
PID = 24657 TID = 24657
24657 24662 24663 24664 24666 24667 24669 24671 24672 24673 24674 24675 24678 24679 24681 24682 24683 24686 24687 24688 24689 24691 24692 24695 29955 29956 29957 29958 29959 29960 29961 29963 29964 

Maps Information
a290a000 a3109000 rw-p [stack:29964]
a310a000 a3909000 rw-p [stack:29963]
a390a000 a4109000 rw-p [stack:29961]
a410a000 a4909000 rw-p [stack:29960]
a490a000 a5109000 rw-p [stack:29959]
a510a000 a5909000 rw-p [stack:29958]
a590a000 a6109000 rw-p [stack:29957]
a610a000 a6909000 rw-p [stack:29956]
a7b2e000 a832d000 rw-p [stack:29955]
a8645000 a8e44000 rw-p [stack:24692]
a8e45000 a9644000 rw-p [stack:24691]
a9901000 aa100000 rw-p [stack:24695]
aa101000 aa900000 rw-p [stack:24689]
aa901000 ab100000 rw-p [stack:24688]
ab101000 ab900000 rw-p [stack:24687]
ab901000 ac100000 rw-p [stack:24686]
ac101000 ac900000 rw-p [stack:24683]
ac901000 ad100000 rw-p [stack:24682]
ad101000 ad900000 rw-p [stack:24681]
ad901000 ae100000 rw-p [stack:24679]
ae101000 ae900000 rw-p [stack:24678]
ae901000 af100000 rw-p [stack:24675]
af101000 af900000 rw-p [stack:24674]
afa7a000 b0279000 rw-p [stack:24673]
b027a000 b0a79000 rw-p [stack:24672]
b0a7a000 b1279000 rw-p [stack:24671]
b1279000 b1287000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b12a5000 b12da000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b12e3000 b12e4000 r-xp /usr/lib/libbincfg.so.1.1
b12ec000 b1332000 r-xp /usr/lib/libcamera-interface-sprd-sc7727.so.0.0.0
b1342000 b138a000 r-xp /usr/lib/libcamerahal.so.0.0.0
b1398000 b13a2000 r-xp /usr/lib/gstreamer-0.10/libgstevasimagesink.so
b13aa000 b13c0000 r-xp /usr/lib/gstreamer-0.10/libgstcamerasrc.so
b13c9000 b1bc8000 rw-p [stack:24669]
b1bc9000 b23c8000 rw-p [stack:24667]
b23c9000 b2bc8000 rw-p [stack:24666]
b2bd6000 b2bd7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b2c85000 b3484000 rw-p [stack:24664]
b3499000 b349a000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b34a2000 b34b9000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3660000 b3664000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b366e000 b3e6d000 rw-p [stack:24662]
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
b6ef6000 b6ef9000 rw-p [stack:24663]
b6efa000 b6efd000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f07000 b6f0b000 r-xp /usr/lib/libsys-assert.so
b6f14000 b6f31000 r-xp /lib/ld-2.13.so
b6f3a000 b6f3f000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b8d97000 b8dc1000 rw-p [heap]
b8dc1000 b90f5000 rw-p [heap]
be80d000 be82e000 rw-p [stack]
b8d97000 b8dc1000 rw-p [heap]
b8dc1000 b90f5000 rw-p [heap]
be80d000 be82e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24657)
Call Stack Count: 20
 0: strlen + 0x4 (0xb6c3fd64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0xcb8 (0xb6c0ab7c) [/lib/libc.so.6] + 0x3db7c
 2: __vsnprintf_chk + 0xa0 (0xb6ca4b88) [/lib/libc.so.6] + 0xd7b88
 3: dlog_print + 0x42 (0xb6ed4063) [/usr/lib/libdlog.so.0] + 0x1063
 4: main_view_add + 0x1be (0xb4d407f7) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x27f7
 5: _app_resume_cb + 0x3c (0xb4d42f59) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x4f59
 6: (0xb64dfc89) [/usr/lib/libcapi-appfw-application.so.0] + 0x1c89
 7: (0xb6efbefb) [/usr/lib/libappcore-efl.so.1] + 0x1efb
 8: (0xb6efc117) [/usr/lib/libappcore-efl.so.1] + 0x2117
 9: (0xb6b42c6b) [/usr/lib/libecore.so.1] + 0x7c6b
10: (0xb6b46283) [/usr/lib/libecore.so.1] + 0xb283
11: ecore_main_loop_begin + 0x30 (0xb6b46691) [/usr/lib/libecore.so.1] + 0xb691
12: appcore_efl_main + 0x17e (0xb6efc387) [/usr/lib/libappcore-efl.so.1] + 0x2387
13: ui_app_main + 0xb0 (0xb64e0499) [/usr/lib/libcapi-appfw-application.so.0] + 0x2499
14: app_run + 0x4e (0xb4d42e8f) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x4e8f
15: main + 0x26 (0xb4d4322f) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x522f
16: _main_view_timer_cb + 0x46 (0xb6f3cdc7) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x2dc7
17: (0xb6f3bd8f) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x1d8f
18: __libc_start_main + 0x114 (0xb6be482c) [/lib/libc.so.6] + 0x1782c
19: (0xb6f3c0d4) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x20d4
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
30, 60
08-08 04:34:00.006+0530 I/Tizen::System( 1120): (103) > Original Time is 2015 8/7, 23:4:0:20
08-08 04:34:00.006+0530 I/Tizen::System( 1120): (123) > Current Time is 2015 8/8, 4:34:0
08-08 04:34:00.006+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59980 milliseconds from now
08-08 04:34:00.016+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-08 04:34:00.016+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(false)
08-08 04:34:59.996+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'L'
08-08 04:34:59.996+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
08-08 04:34:59.996+0530 I/Tizen::Base::Runtime( 1120): (251) > The timer is not started.
08-08 04:34:59.996+0530 I/Tizen::System( 1120): (85) > Current Epoch is 1438988700.
08-08 04:34:59.996+0530 I/Tizen::System( 1120): (89) > Calendar time is sec:0, min:5, hour:23, day:7, mon:7, year:115, wday5, year:218, dst:0
08-08 04:34:59.996+0530 I/Tizen::System( 1120): (99) > Current time zone is Asia/Kolkata, 330, 60
08-08 04:34:59.996+0530 I/Tizen::System( 1120): (103) > Original Time is 2015 8/7, 23:5:0:4
08-08 04:34:59.996+0530 I/Tizen::System( 1120): (123) > Current Time is 2015 8/8, 4:35:0
08-08 04:34:59.996+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 26699996 milliseconds from now
08-08 04:35:00.006+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'F'
08-08 04:35:00.006+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(true)
08-08 04:35:00.006+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
08-08 04:35:00.006+0530 I/Tizen::System( 1120): (85) > Current Epoch is 1438988700.
08-08 04:35:00.006+0530 I/Tizen::System( 1120): (89) > Calendar time is sec:0, min:5, hour:23, day:7, mon:7, year:115, wday5, year:218, dst:0
08-08 04:35:00.006+0530 I/Tizen::System( 1120): (99) > Current time zone is Asia/Kolkata, 330, 60
08-08 04:35:00.006+0530 I/Tizen::System( 1120): (103) > Original Time is 2015 8/7, 23:5:0:17
08-08 04:35:00.006+0530 I/Tizen::System( 1120): (123) > Current Time is 2015 8/8, 4:35:0
08-08 04:35:00.006+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59983 milliseconds from now
08-08 04:35:00.016+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-08 04:35:00.016+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(false)
08-08 04:35:05.036+0530 D/dalvikvm(24010): GC_EXPLICIT freed 18K, 50% free 2863K/5703K, external 1962K/2073K, paused 21ms
08-08 04:35:59.996+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'L'
08-08 04:35:59.996+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
08-08 04:35:59.996+0530 I/Tizen::Base::Runtime( 1120): (251) > The timer is not started.
08-08 04:35:59.996+0530 I/Tizen::System( 1120): (85) > Current Epoch is 1438988760.
08-08 04:35:59.996+0530 I/Tizen::System( 1120): (89) > Calendar time is sec:0, min:6, hour:23, day:7, mon:7, year:115, wday5, year:218, dst:0
08-08 04:35:59.996+0530 I/Tizen::System( 1120): (99) > Current time zone is Asia/Kolkata, 330, 60
08-08 04:35:59.996+0530 I/Tizen::System( 1120): (103) > Original Time is 2015 8/7, 23:6:0:7
08-08 04:35:59.996+0530 I/Tizen::System( 1120): (123) > Current Time is 2015 8/8, 4:36:0
08-08 04:35:59.996+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 26639993 milliseconds from now
08-08 04:36:00.006+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(true)
08-08 04:36:00.006+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
08-08 04:36:00.006+0530 I/Tizen::System( 1120): (85) > Current Epoch is 1438988760.
08-08 04:36:00.006+0530 I/Tizen::System( 1120): (89) > Calendar time is sec:0, min:6, hour:23, day:7, mon:7, year:115, wday5, year:218, dst:0
08-08 04:36:00.006+0530 I/Tizen::System( 1120): (99) > Current time zone is Asia/Kolkata, 330, 60
08-08 04:36:00.006+0530 I/Tizen::System( 1120): (103) > Original Time is 2015 8/7, 23:6:0:18
08-08 04:36:00.006+0530 I/Tizen::System( 1120): (123) > Current Time is 2015 8/8, 4:36:0
08-08 04:36:00.006+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59982 milliseconds from now
08-08 04:36:00.016+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-08 04:36:00.016+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'F'
08-08 04:36:00.016+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(false)
08-08 04:36:16.036+0530 W/LOCKSCREEN(  576): property.c: _vconf_cb(210) > [_vconf_cb:210:W] property 200 is changed to 58
08-08 04:36:16.036+0530 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:40000:CONF_CHANGED
08-08 04:36:16.036+0530 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:40000 event_info:200
08-08 04:36:16.036+0530 W/LOCKSCREEN(  576): view-mgr.c: _event_route(108) > [_event_route:108:W] event:40000 event_info:200
08-08 04:36:25.996+0530 W/ALARM_MANAGER(  402): alarm-manager.c: __alarm_expired(1223) > alarm_id[1007976630] is expired.
08-08 04:36:25.996+0530 W/ALARM_MANAGER(  402): alarm-manager.c: __alarm_remove_from_list(389) > [alarm-server]:Remove alarm id(1007976630)
08-08 04:36:25.996+0530 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 7-8-2015, 23:11:50 (UTC).
08-08 04:36:25.996+0530 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
08-08 04:36:25.996+0530 W/ALARM_MANAGER(23889): alarm-lib.c: __expire_alarm_filter(141) > [alarm-lib] : Alarm expired for [ALARM.aemail-service-0] : Alarm id [1007976630]
08-08 04:36:26.016+0530 W/ALARM_MANAGER(  402): alarm-manager.c: __alarm_remove_from_list(389) > [alarm-server]:Remove alarm id(1914332298)
08-08 04:36:26.016+0530 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 7-8-2015, 23:11:50 (UTC).
08-08 04:36:26.146+0530 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
08-08 04:36:26.156+0530 W/ALARM_MANAGER(  402): alarm-manager.c: alarm_manager_alarm_delete(1750) > alarm_id[1914332298] is removed.
08-08 04:36:26.826+0530 W/ALARM_MANAGER(23889): alarm-lib.c: alarmmgr_add_alarm(1029) > trigger_at_time(1740), start(8-8-2015, 05:05:27), repeat(0), interval(0), type(-2147483646)
08-08 04:36:26.846+0530 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/email-service, ret : 0
08-08 04:36:26.846+0530 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/email-service, ret : 0
08-08 04:36:26.856+0530 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/email-service, ret : 0
08-08 04:36:26.866+0530 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/email-service, ret : 0
08-08 04:36:26.876+0530 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/email-service, ret : 0
08-08 04:36:26.886+0530 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/email-service, ret : 0
08-08 04:36:26.886+0530 W/ALARM_MANAGER(  402): alarm-manager-schedule.c: __alarm_next_duetime_once(183) > current_dst = 0
08-08 04:36:26.886+0530 W/ALARM_MANAGER(  402): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1438990527, Sat Aug  8 05:05:27 2015
08-08 04:36:26.886+0530 W/ALARM_MANAGER(  402): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 1179625873, next duetime: 1438990527
08-08 04:36:26.886+0530 W/ALARM_MANAGER(  402): alarm-manager.c: __alarm_add_to_list(310) > [alarm-server]: After add alarm_id(1179625873)
08-08 04:36:26.886+0530 W/ALARM_MANAGER(  402): alarm-manager.c: __alarm_create(873) > [alarm-server]:alarm_context.c_due_time(1438989110), due_time(1438990527)
08-08 04:36:26.886+0530 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(193) > Setted RTC Alarm date/time is 7-8-2015, 23:11:50 (UTC).
08-08 04:36:26.886+0530 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(205) > [alarm-server]RTC alarm is set and it's ON.
08-08 04:36:48.266+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'L'
08-08 04:36:48.266+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'F'
08-08 04:36:48.266+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
08-08 04:36:48.266+0530 I/Tizen::Base::Runtime( 1120): (251) > The timer is not started.
08-08 04:36:48.266+0530 I/Tizen::System( 1120): (85) > Current Epoch is 1438988808.
08-08 04:36:48.266+0530 I/Tizen::System( 1120): (89) > Calendar time is sec:48, min:6, hour:23, day:7, mon:7, year:115, wday5, year:218, dst:0
08-08 04:36:48.266+0530 I/Tizen::System( 1120): (99) > Current time zone is Asia/Kolkata, 330, 60
08-08 04:36:48.266+0530 I/Tizen::System( 1120): (103) > Original Time is 2015 8/7, 23:6:48:277
08-08 04:36:48.266+0530 I/Tizen::System( 1120): (123) > Current Time is 2015 8/8, 4:36:48
08-08 04:36:48.266+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 423369617 milliseconds from now
08-08 04:36:48.276+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(true)
08-08 04:36:48.286+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(false)
08-08 04:36:48.286+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
08-08 04:36:48.286+0530 I/Tizen::System( 1120): (85) > Current Epoch is 911972055560.
08-08 04:36:48.286+0530 I/Tizen::System( 1120): (89) > Calendar time is sec:48, min:6, hour:23, day:7, mon:7, year:115, wday5, year:218, dst:0
08-08 04:36:48.286+0530 I/Tizen::System( 1120): (99) > Current time zone is Asia/Kolkata, 330, 60
08-08 04:36:48.286+0530 I/Tizen::System( 1120): (103) > Original Time is 2015 8/7, 23:6:48:295
08-08 04:36:48.286+0530 I/Tizen::System( 1120): (123) > Current Time is 2015 8/8, 4:36:48
08-08 04:36:48.286+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 599981 milliseconds from now
08-08 04:36:59.996+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'L'
08-08 04:36:59.996+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
08-08 04:36:59.996+0530 I/Tizen::Base::Runtime( 1120): (251) > The timer is not started.
08-08 04:36:59.996+0530 I/Tizen::System( 1120): (85) > Current Epoch is 1438988820.
08-08 04:36:59.996+0530 I/Tizen::System( 1120): (89) > Calendar time is sec:0, min:7, hour:23, day:7, mon:7, year:115, wday5, year:218, dst:0
08-08 04:36:59.996+0530 I/Tizen::System( 1120): (99) > Current time zone is Asia/Kolkata, 330, 60
08-08 04:36:59.996+0530 I/Tizen::System( 1120): (103) > Original Time is 2015 8/7, 23:7:0:10
08-08 04:36:59.996+0530 I/Tizen::System( 1120): (123) > Current Time is 2015 8/8, 4:37:0
08-08 04:36:59.996+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 26579990 milliseconds from now
08-08 04:37:00.006+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'F'
08-08 04:37:00.006+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(true)
08-08 04:37:00.006+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(198) > Setting Timer for Android (Alarm)
08-08 04:37:00.006+0530 I/Tizen::System( 1120): (85) > Current Epoch is 1438988820.
08-08 04:37:00.006+0530 I/Tizen::System( 1120): (89) > Calendar time is sec:0, min:7, hour:23, day:7, mon:7, year:115, wday5, year:218, dst:0
08-08 04:37:00.006+0530 I/Tizen::System( 1120): (99) > Current time zone is Asia/Kolkata, 330, 60
08-08 04:37:00.006+0530 I/Tizen::System( 1120): (103) > Original Time is 2015 8/7, 23:7:0:18
08-08 04:37:00.006+0530 I/Tizen::System( 1120): (123) > Current Time is 2015 8/8, 4:37:0
08-08 04:37:00.006+0530 I/AclService( 1120): void AlarmService::ProcessMessage(int, int, int, int, int, int, int, int)(258) > Set timer for 59982 milliseconds from now
08-08 04:37:00.016+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-08 04:37:00.016+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(false)
08-08 04:37:05.026+0530 D/dalvikvm(24010): GC_EXPLICIT freed 20K, 50% free 2863K/5703K, external 1962K/2073K, paused 21ms
08-08 04:37:38.786+0530 W/LOCKSCREEN(  576): dbus.c: _dbus_message_recv_cb(127) > [_dbus_message_recv_cb:127:W] LCD on
08-08 04:37:38.786+0530 W/LOCKSCREEN(  576): event.c: _lcd_on_cb(53) > [_lcd_on_cb:53:W] Dbus LCD on
08-08 04:37:38.786+0530 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:30001:LCD_ON
08-08 04:37:38.786+0530 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:30001 event_info:0
08-08 04:37:38.786+0530 W/LOCKSCREEN(  576): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:3
08-08 04:37:38.786+0530 W/LOCKSCREEN(  576): daemon.c: _state_enter(329) > [_state_enter:329:W] PAUSE => WILL RESUME
08-08 04:37:38.786+0530 E/LOCKSCREEN(  576): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
08-08 04:37:38.806+0530 I/indicator(  508): indicator_ui.c: on_changed_receive(1443) > "LCD On handling"
08-08 04:37:38.816+0530 E/EFL     (  576): elementary<576> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0x1b69128 in function: elm_label_slide_mode_set, of type: 'rectangle' when expecting type: 'elm_label'
08-08 04:37:38.816+0530 E/EFL     (  576): elementary<576> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0x1b69128 in function: elm_label_slide_go, of type: 'rectangle' when expecting type: 'elm_label'
08-08 04:37:38.816+0530 E/EFL     (  576): elementary<576> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0x1c78f20 in function: elm_label_slide_mode_set, of type: 'edje' when expecting type: 'elm_label'
08-08 04:37:38.816+0530 E/EFL     (  576): elementary<576> elm_widget.c:4331 elm_widget_type_check() Passing Object: 0x1c78f20 in function: elm_label_slide_go, of type: 'edje' when expecting type: 'elm_label'
08-08 04:37:38.836+0530 W/LOCKSCREEN(  576): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:4
08-08 04:37:38.836+0530 W/LOCKSCREEN(  576): daemon.c: _state_enter(329) > [_state_enter:329:W] WILL RESUME => RESUME
08-08 04:37:38.836+0530 W/LOCKSCREEN(  576): daemon.c: _lcd_timeout_timer_set(613) > [_lcd_timeout_timer_set:613:W] lcd off timer set:30.000000
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 331 5 28 25"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 382 387 5 28 25"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 595 5 28 25"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 375 623 5 28 25"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 651 5 28 25"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
08-08 04:37:38.946+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 382 707 5 28 25"
08-08 04:37:38.966+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-08 04:37:38.966+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-08 04:37:38.966+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-08 04:37:38.966+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-08 04:37:38.966+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-08 04:37:38.966+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 331 5 28 25"
08-08 04:37:38.966+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
08-08 04:37:38.966+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 382 387 5 28 25"
08-08 04:37:38.976+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-08 04:37:38.976+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-08 04:37:38.976+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-08 04:37:38.976+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-08 04:37:38.976+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 595 5 28 25"
08-08 04:37:38.976+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 375 623 5 28 25"
08-08 04:37:38.976+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 651 5 28 25"
08-08 04:37:38.976+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
08-08 04:37:38.976+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 382 707 5 28 25"
08-08 04:37:39.476+0530 I/Tizen::System( 1053): (280) > The screen has been turned on.
08-08 04:37:39.476+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-08 04:37:39.476+0530 W/CAM_APP ( 9718): cam_app.c: __cam_app_display_state_changed_cb(7919) > [33mapp state is PRELAUNCH. ignore this[0m
08-08 04:37:39.476+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:39.486+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-08 04:37:39.486+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:37:39.486+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:37:39.486+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:37:39.486+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:37:39.486+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:37:39.486+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:37:39.486+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:37:39.486+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:37:39.486+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:37:39.486+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:37:39.496+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:37:39.496+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:37:39.496+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:37:39.496+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:37:39.496+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:37:39.496+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:37:39.496+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:37:39.496+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:37:39.496+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:37:39.496+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:37:39.526+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:37:39.616+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:37:39.656+0530 E/CAPI_LOCATION_MANAGER(  939): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
08-08 04:37:39.656+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationVirtual) step(-21) failed(2 / No such file or directory)
08-08 04:37:39.656+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationVirtual : read buf error(-21). break
08-08 04:37:39.656+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationVirtual error
08-08 04:37:39.656+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationTest) step(-21) failed(2 / No such file or directory)
08-08 04:37:39.656+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationTest : read buf error(-21). break
08-08 04:37:39.656+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationTest error
08-08 04:37:39.656+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationVirtual) step(-21) failed(2 / No such file or directory)
08-08 04:37:39.656+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationVirtual : read buf error(-21). break
08-08 04:37:39.656+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationVirtual error
08-08 04:37:39.666+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/OperationVirtual) step(-21) failed(2 / No such file or directory)
08-08 04:37:39.666+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/OperationVirtual : read buf error(-21). break
08-08 04:37:39.666+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/OperationVirtual error
08-08 04:37:39.666+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/DynamicAcc) step(-21) failed(2 / No such file or directory)
08-08 04:37:39.666+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/DynamicAcc : read buf error(-21). break
08-08 04:37:39.666+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/QoP/DynamicAcc error
08-08 04:37:39.666+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/Timeout) step(-21) failed(2 / No such file or directory)
08-08 04:37:39.666+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/Timeout : read buf error(-21). break
08-08 04:37:39.666+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/QoP/Timeout error
08-08 04:37:39.666+0530 E/VCONF   (  861): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/location/gps/QoP/Accuracy) step(-21) failed(2 / No such file or directory)
08-08 04:37:39.666+0530 E/VCONF   (  861): vconf.c: _vconf_get_key(2111) > db/location/gps/QoP/Accuracy : read buf error(-21). break
08-08 04:37:39.666+0530 E/VCONF   (  861): vconf.c: vconf_get_int(2379) > vconf_get_int(861) : db/location/gps/QoP/Accuracy error
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] gps 0!"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(726) > "Pack to SYSTEM list : gps"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-08 04:37:39.686+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 1e63968 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : gps 418 0 28 36"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 382 387 5 28 25"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(716) > "[icon_box_pack] gps 1!"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack(726) > "Pack to SYSTEM list : gps"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-08 04:37:39.686+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 1e1c600 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : gps 738 0 28 36"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 595 5 28 25"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 375 623 5 28 25"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 651 5 28 25"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
08-08 04:37:39.686+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 382 707 5 28 25"
08-08 04:37:39.726+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:39.746+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:37:39.786+0530 E/VCONF   (  939): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
08-08 04:37:39.786+0530 E/VCONF   (  939): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
08-08 04:37:39.786+0530 E/VCONF   (  939): vconf.c: vconf_get_int(2379) > vconf_get_int(939) : file/private/wifi/always_allow_scanning error
08-08 04:37:39.786+0530 E/VCONF   (  939): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-file/private/wifi/always_allow_scanning) step(-21) failed(2 / No such file or directory)
08-08 04:37:39.796+0530 E/VCONF   (  939): vconf.c: _vconf_get_key(2111) > file/private/wifi/always_allow_scanning : read buf error(-21). break
08-08 04:37:39.796+0530 E/VCONF   (  939): vconf.c: vconf_get_int(2379) > vconf_get_int(939) : file/private/wifi/always_allow_scanning error
08-08 04:37:39.806+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-08 04:37:39.806+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-08 04:37:39.946+0530 I/CAPI_APPFW_APPLICATION(24657): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:37:39.946+0530 I/CAPI_APPFW_APPLICATION( 3387): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:37:39.946+0530 W/LOCKSCREEN(  576): dbus.c: _dbus_message_recv_cb(167) > [_dbus_message_recv_cb:167:W] rotation changed:0
08-08 04:37:39.946+0530 W/LOCKSCREEN(  576): camera.c: _angle_changed_cb(198) > [_angle_changed_cb:198:W] angle:0
08-08 04:37:39.946+0530 W/LOCKSCREEN(  576): camera.c: camera_view_action(157) > [camera_view_action:157:W] rotation:0
08-08 04:37:39.946+0530 I/CAPI_APPFW_APPLICATION(22405): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:37:39.946+0530 I/CAPI_APPFW_APPLICATION( 9718): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-08 04:37:39.946+0530 W/CAM_APP ( 9718): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-08 04:37:39.976+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:40.226+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:40.486+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:40.646+0530 I/Tizen::Net::Wifi( 1082): (928) > The background scan result updated.
08-08 04:37:40.646+0530 I/Tizen::Net::Wifi( 1082): (934) > Fire event [WIFI_EVENT_SCAN_COMPLETED]
08-08 04:37:40.736+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:40.746+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-08 04:37:40.746+0530 I/CAPI_TELEPHONY(  939): telephony_network.c: telephony_network_get_roaming_status(135) > status:[0]
08-08 04:37:40.856+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:37:40.906+0530 E/CAPI_LOCATION_MANAGER(  939): location_product.c: _location_manager_gps_state_cb(102) > _location_manager_gps_state_cb
08-08 04:37:40.906+0530 I/indicator(  508): indicator_box_util.c: icon_box_pack_append(874) > "[icon_box_pack_append] 377!"
08-08 04:37:40.906+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-08 04:37:40.906+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-08 04:37:40.906+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-08 04:37:40.906+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 390 0 56 36"
08-08 04:37:40.906+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-08 04:37:40.906+0530 I/indicator(  508): indicator_icon_util.c: _img_icon_add(292) > "evas_icon_size = Original(25, 25), Scaled(25.000000, 25.000000)"
08-08 04:37:40.906+0530 I/EFL-ASSIST(  508): efl_assist_theme_color.cpp: ea_theme_object_color_set(1414) > obj: 1d90c70 (elm_image), color code: AO004, color [255, 255, 255, 255]
08-08 04:37:40.906+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 0 0 0 0"
08-08 04:37:40.906+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-08 04:37:40.906+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 382 359 5 28 25"
08-08 04:37:40.916+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-08 04:37:40.916+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-08 04:37:40.916+0530 I/indicator(  508): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-08 04:37:40.916+0530 I/indicator(  508): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 710 0 56 36"
08-08 04:37:40.916+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 343 567 5 28 25"
08-08 04:37:40.916+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 375 595 5 28 25"
08-08 04:37:40.916+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 377 623 5 28 25"
08-08 04:37:40.916+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-08 04:37:40.916+0530 I/indicator(  508): indicator_box_util.c: _update_display(585) > "Noti Icon : 382 679 5 28 25"
08-08 04:37:40.986+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:41.046+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-08 04:37:41.236+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:41.496+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:41.756+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:42.006+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:42.016+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-08 04:37:42.016+0530 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80001:VIEW_GESTURED
08-08 04:37:42.016+0530 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:80001 event_info:0
08-08 04:37:42.016+0530 W/LOCKSCREEN(  576): daemon.c: _lcd_timeout_timer_unset(622) > [_lcd_timeout_timer_unset:622:W] lcd off timer unset
08-08 04:37:42.016+0530 W/LOCKSCREEN(  576): view-mgr.c: _event_route(108) > [_event_route:108:W] event:80001 event_info:0
08-08 04:37:42.016+0530 W/LOCKSCREEN(  576): view-mgr.c: _state_transit(45) > [_state_transit:45:W] state transit:2
08-08 04:37:42.016+0530 W/LOCKSCREEN(  576): view-mgr.c: _state_transit(48) > [_state_transit:48:W] already in same state:2
08-08 04:37:42.016+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:37:42.016+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:37:42.016+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:37:42.016+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:37:42.016+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:37:42.026+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:37:42.026+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:37:42.026+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:37:42.026+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:37:42.026+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:37:42.026+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:37:42.256+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:42.506+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:42.756+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:43.006+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:43.066+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:37:43.116+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-08 04:37:43.116+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-08 04:37:43.256+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:43.376+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-08 04:37:43.376+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-08 04:37:43.506+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:43.626+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-08 04:37:43.626+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-08 04:37:43.766+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:44.016+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:44.026+0530 E/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(285) > 
08-08 04:37:44.026+0530 W/LOCKSCREEN(  576): progress_circle.c: unlock_mouse_up(295) > [unlock_mouse_up:295:W] already unlocked
08-08 04:37:44.046+0530 E/LOCKSCREEN(  576): password-verification.c: __password_verification_check_phone_password(254) > [__password_verification_check_phone_password:254:E] correct password!
08-08 04:37:44.046+0530 W/LOCKSCREEN(  576): simple-password.c: _pwd_verify_result_cb(522) > [_pwd_verify_result_cb:522:W] event:3
08-08 04:37:44.056+0530 W/LOCKSCREEN(  576): daemon.c: lockd_event_delay(917) > [lockd_event_delay:917:W] dealyed event:2:UNLOCK wait for:0.500000
08-08 04:37:44.246+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-08 04:37:44.246+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:37:44.246+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:37:44.246+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:37:44.246+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:37:44.246+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:37:44.246+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-08 04:37:44.256+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-08 04:37:44.256+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-08 04:37:44.256+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-08 04:37:44.256+0530 I/Tizen::System( 1120): (637) > result is 1.
08-08 04:37:44.266+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:44.516+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:44.556+0530 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:2 event_info:0
08-08 04:37:44.556+0530 W/LOCKSCREEN(  576): daemon.c: _state_transit(390) > [_state_transit:390:W] state transit:6
08-08 04:37:44.556+0530 W/LOCKSCREEN(  576): daemon.c: _state_enter(329) > [_state_enter:329:W] RESUME => HIDE
08-08 04:37:44.556+0530 E/WALLPAPER_SERVICE_COMMON(  576): wps_common_storage.c: _common_storage_get_active_image_info_id(2710) > [0;31m* Critical * No records found[0;m
08-08 04:37:44.656+0530 W/LOCKSCREEN(  576): util-daemon.c: _ckmc_unlock_timer_cb(196) > [_ckmc_unlock_timer_cb:196:W] key manager unlock:0
08-08 04:37:44.656+0530 W/PROCESSMGR(  343): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=24657
08-08 04:37:44.666+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:37:44.676+0530 I/indicator(  508): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = org.tizen.watchdog, pid = 24657"
08-08 04:37:44.686+0530 W/LOCKSCREEN(  576): lockscreen-lite.c: _window_visibility_cb(278) > [_window_visibility_cb:278:W] Window [0x2000008] is now visible(1)
08-08 04:37:44.686+0530 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:10002:WIN_BECOME_INVISIBLE
08-08 04:37:44.686+0530 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:10002 event_info:0
08-08 04:37:44.686+0530 I/CAPI_APPFW_APPLICATION(  576): app_main.c: app_appcore_pause(202) > app_appcore_pause
08-08 04:37:44.686+0530 E/LOCKSCREEN(  576): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
08-08 04:37:44.686+0530 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:20002:APP_PAUSE
08-08 04:37:44.686+0530 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:20002 event_info:0
08-08 04:37:44.686+0530 I/CAPI_APPFW_APPLICATION(24657): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
08-08 04:37:44.736+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:37:44.736+0530 I/Tizen::System( 1053): (259) > Active app [org.tizen.], current [com.samsun] 
08-08 04:37:44.736+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-08 04:37:44.746+0530 I/Tizen::System( 1120): (101) > Active App is org.tizen.watchdog. GetApp id ACL111OMWW.AclService
08-08 04:37:44.766+0530 I/SECURE_STORAGE(  389): ss_server_ipc.c: SsServerComm(251) > write succeed
08-08 04:37:44.766+0530 I/Tizen::App(  999): (124) > app(ACL111OMWW.AclService), clientId(1120)
08-08 04:37:44.776+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-08 04:37:44.786+0530 D/PowerManagerService( 1575): calling setSysScreenBrightness(brightness = 255)
08-08 04:37:44.786+0530 I/power   ( 1575): *** set_screen_state 1
08-08 04:37:44.786+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'L'
08-08 04:37:44.786+0530 D/SensorService( 1575): actuateSensor
08-08 04:37:44.786+0530 D/AclServiceManager( 1575): -----*******------------ enableSensor  : 0
08-08 04:37:44.786+0530 D/SensorService( 1575): setSensorDelay
08-08 04:37:44.786+0530 D/AclServiceManager( 1575): -----*******------------ setSensorDelay : 0 to 200
08-08 04:37:44.786+0530 D/SensorService( 1575): setSensorDelay
08-08 04:37:44.786+0530 D/AclServiceManager( 1575): -----*******------------ setSensorDelay : 0 to 200
08-08 04:37:44.786+0530 D/ACL     ( 1575): ************ onActivityResumed()  activity = ComponentInfo{com.omww.launcher/com.omww.launcher.Launcher}
08-08 04:37:44.786+0530 D/ACL     ( 1575): >>>>>>>>  send : cmd=CMD_SHOW_DESKTOP  pkg= null  taskid=0 status=-1
08-08 04:37:44.796+0530 W/TIZEN_N_CAMERA(24657): camera.c: camera_create(764) > [camera_create]device name = [1]
08-08 04:37:44.796+0530 I/AclService( 1120): void SocketThread::send_flinger(int, const char*, int, int)(396) > handle_app_manager_msg: cmd=7(CMD_SHOW_DESKTOP) taskid=0  pkg='' status='-1' app=''
08-08 04:37:44.796+0530 I/PowerManagerService-JNI( 1575): sending ACL screen state 'F'
08-08 04:37:44.796+0530 I/AclService( 1120): void minimize()(280) > Minimizing all vfb clients
08-08 04:37:44.796+0530 I/AclService( 1120): void minimize()(283) > minimizing {pkg=surfaceflinger fd=98}
08-08 04:37:44.796+0530 I/AclService( 1120): virtual void SharedSettingService::OnAclCommandReceived(AclCommand&)(160) > Received aclCommand: 0x70010 (16)
08-08 04:37:44.796+0530 W/TIZEN_N_CAMERA(24657): camera.c: camera_create(824) > camera handle 0xa7138df0
08-08 04:37:44.806+0530 W/TIZEN_N_CAMERA(24657): camera.c: camera_start_preview(869) > camera_start_preview - start
08-08 04:37:44.806+0530 W/LOCKSCREEN(  576): view-mgr.c: _event_route(108) > [_event_route:108:W] event:2 event_info:0
08-08 04:37:44.806+0530 E/LOCKSCREEN(  576): default-unlock.c: default_unlock_hide_on_noti_tapped(408) > Failed to get selected noti
08-08 04:37:44.806+0530 W/LOCKSCREEN(  576): daemon.c: lockd_event(904) > [lockd_event:904:W] event:80000:VIEW_IDLE
08-08 04:37:44.806+0530 W/LOCKSCREEN(  576): daemon.c: _event_route(723) > [_event_route:723:W] event:80000 event_info:0
08-08 04:37:44.826+0530 E/LOCKSCREEN(  576): background-view.c: background_image_next_set(179) > [background_image_next_set:179:E] fopen wallpaper txt file failed.
08-08 04:37:44.836+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(true)
08-08 04:37:44.846+0530 E/Tizen::Io( 1120): (133) > [E_INVALID_ARG] The application id is empty.
08-08 04:37:44.846+0530 I/Tizen::Base::Runtime( 1120): (251) > The timer is not started.
08-08 04:37:44.846+0530 I/Tizen::System( 1120): (461) > change cpu power policy: keepAwake(false)
08-08 04:37:44.886+0530 E/VCONF   (24657): vconf-kdb.c: _vconf_kdb_add_notify(313) > _vconf_kdb_add_notify : key(db/setting/sound/sound_on) has same callback(0xb4ca3279)
08-08 04:37:44.886+0530 E/VCONF   (24657): vconf-kdb.c: _vconf_kdb_add_notify(313) > _vconf_kdb_add_notify : key(memory/private/sound/volume/system) has same callback(0xb4b50169)
08-08 04:37:44.886+0530 E/TIZEN_N_CAMERA(24657): camera.c: __convert_camera_error_code(234) > [__camera_start_continuous_focusing] ERROR_NOT_SUPPORTED(0xc0000002) : core frameworks error code(0x80000107)
08-08 04:37:45.136+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-08 04:37:45.136+0530 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-08 04:37:45.156+0530 W/PROCESSMGR(  343): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=604
08-08 04:37:45.196+0530 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-08 04:37:45.196+0530 E/cluster-home(  604): homescreen-main.cpp: app_resume(422) >  app resume
08-08 04:37:45.216+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-08 04:37:45.226+0530 I/indicator(  508): indicator_ui.c: _property_changed_cb(1238) > "app pkgname = com.samsung.homescreen, pid = 604"
08-08 04:37:45.226+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_create(363) > New handle created[0xb8fe31a8]
08-08 04:37:45.226+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_get_type(412) > Connected Network = 2
08-08 04:37:45.226+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_destroy(379) > Destroy handle: 0xb8fe31a8
08-08 04:37:45.246+0530 E/weather-live(22405): main.c: dynamicbox_update_content(1950) > [0;40;31mcur_city_index: 0[0;m
08-08 04:37:45.246+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_create(363) > New handle created[0xb9103aa0]
08-08 04:37:45.246+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_get_type(412) > Connected Network = 2
08-08 04:37:45.246+0530 I/CAPI_NETWORK_CONNECTION(22405): connection.c: connection_destroy(379) > Destroy handle: 0xb9103aa0
08-08 04:37:45.246+0530 E/weather-live(22405): live-dbf-weather.c: live_weather_update_weather_info(1103) > [0;40;31mcity_index:0[0;m
08-08 04:37:45.266+0530 W/CRASH_MANAGER(29966): worker.c: worker_job(1236) > 1124657776174143898886
