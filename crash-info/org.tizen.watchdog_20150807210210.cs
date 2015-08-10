S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.1
Build-Number: Z130HDDU0BOG1
Build-Date: 2015.07.01 21:13:58

Crash Information
Process Name: watchdog
PID: 7254
Date: 2015-08-07 21:02:10+0530
Executable File Path: /opt/usr/apps/org.tizen.watchdog/bin/watchdog
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7254, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xb6e99ad4, r3   = 0x00000000
r4   = 0xb4d4cd44, r5   = 0xb4d44190
r6   = 0xb8ecce00, r7   = 0xbe82cc40
r8   = 0x00000000, r9   = 0xb912a938
r10  = 0xb9129848, fp   = 0x00000001
ip   = 0x00000000, sp   = 0xbe82cc40
lr   = 0xb6ebe3f8, pc   = 0xb4d42d86
cpsr = 0x60000030

Memory Information
MemTotal:   730748 KB
MemFree:     19428 KB
Buffers:     28800 KB
Cached:     274512 KB
VmPeak:     254452 KB
VmSize:     254448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21896 KB
VmRSS:       21892 KB
VmData:     189096 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       31064 KB
VmPTE:         120 KB
VmSwap:          0 KB

Threads Information
Threads: 23
PID = 7254 TID = 7254
7254 7261 7262 7265 7266 9053 9054 9055 9056 9057 9058 9061 9062 9063 9064 9065 9066 9067 9068 9069 9071 9072 9079 

Maps Information
a830f000 a8314000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/linux-gnueabi-armv7l-1.7.99/module.so
a831c000 a832c000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
a8901000 a9100000 rw-p [stack:9072]
a9101000 a9900000 rw-p [stack:9054]
a9901000 aa100000 rw-p [stack:9055]
aa101000 aa900000 rw-p [stack:9053]
aaf8a000 ab789000 rw-p [stack:9071]
ab78a000 abf89000 rw-p [stack:9079]
abf8a000 ac789000 rw-p [stack:9069]
ac78a000 acf89000 rw-p [stack:9068]
acf8a000 ad789000 rw-p [stack:9067]
ad78a000 adf89000 rw-p [stack:9066]
adf8a000 ae789000 rw-p [stack:9065]
ae78a000 aef89000 rw-p [stack:9064]
aef8a000 af789000 rw-p [stack:9063]
af901000 b0100000 rw-p [stack:9057]
b023b000 b0a3a000 rw-p [stack:9062]
b0a3b000 b123a000 rw-p [stack:9061]
b123b000 b1a3a000 rw-p [stack:9058]
b1a7a000 b1a88000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1a99000 b1a9e000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1aa6000 b1adb000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b1ae4000 b1ae5000 r-xp /usr/lib/libbincfg.so.1.1
b1aed000 b1b33000 r-xp /usr/lib/libcamera-interface-sprd-sc7727.so.0.0.0
b1b43000 b1b8b000 r-xp /usr/lib/libcamerahal.so.0.0.0
b1b99000 b1ba3000 r-xp /usr/lib/gstreamer-0.10/libgstevasimagesink.so
b1bab000 b1bc1000 r-xp /usr/lib/gstreamer-0.10/libgstcamerasrc.so
b1bca000 b23c9000 rw-p [stack:9056]
b23e6000 b2be5000 rw-p [stack:7266]
b2be6000 b33e5000 rw-p [stack:7265]
b33f3000 b33f4000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b349a000 b349b000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b34a3000 b34ba000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3661000 b3665000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b366f000 b3e6e000 rw-p [stack:7261]
b3e6e000 b3fb5000 r-xp /usr/lib/driver/libMali.so
b3fc2000 b408c000 r-xp /usr/lib/libCOREGL.so.4.0
b409d000 b40a0000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b40a8000 b40ab000 r-xp /usr/lib/libEGL.so.1.4
b40b3000 b40c1000 r-xp /usr/lib/libGLESv2.so.2.0
b40ca000 b411a000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4360000 b4374000 r-xp /usr/lib/libnetwork.so.0.0.0
b437c000 b4385000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.26
b438d000 b438f000 r-xp /usr/lib/libdevice_info.so.0.0.2
b4397000 b4399000 r-xp /usr/lib/libcryptsvc.so.0.0.2
b43a1000 b43bd000 r-xp /usr/lib/libdrm-service-core-tizen.so.0.3.9
b43d4000 b43db000 r-xp /usr/lib/libminizip.so.1.0.0
b43e3000 b43e5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b43ed000 b43f4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b43fd000 b4419000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4422000 b4428000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b4430000 b4441000 r-xp /lib/libnsl-2.13.so
b444c000 b4454000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.55
b445c000 b445d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b4465000 b4480000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4488000 b448d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b4495000 b449d000 r-xp /usr/lib/libpims-ipc.so.0.1.18
b44a5000 b4506000 r-xp /usr/lib/libasound.so.2.0.0
b4510000 b4514000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b451c000 b451f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b4528000 b452a000 r-xp /usr/lib/libemail-network.so.1.1.0
b4532000 b4536000 r-xp /usr/lib/libstorage.so.0.1
b453e000 b4574000 r-xp /usr/lib/libgmime-2.6.so.0.600.15
b458f000 b46ce000 r-xp /usr/lib/libicui18n.so.51.1
b46de000 b46e2000 r-xp /usr/lib/libbadge.so.0.0.1
b46ea000 b46f1000 r-xp /usr/lib/libfeedback.so.0.1.4
b4705000 b4711000 r-xp /usr/lib/libalarm.so.0.0.0
b471a000 b472d000 r-xp /usr/lib/libaccounts-svc.so.0.2.97
b4735000 b4779000 r-xp /usr/lib/libcontacts-service2.so.0.12.54
b4784000 b482e000 r-xp /usr/lib/libuw-imap-toolkit.so.0.0.0
b483b000 b483f000 r-xp /usr/lib/libss-client.so.1.0.0
b4847000 b4850000 r-xp /usr/lib/libmdm-common.so.1.0.45
b4858000 b48a0000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b48a1000 b48a7000 r-xp /usr/lib/libjson.so.0.1.0
b48af000 b48b7000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b48c6000 b48c8000 r-xp /usr/lib/libiniparser.so.0
b48d2000 b48e8000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b4916000 b4919000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4921000 b4937000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b493f000 b4943000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b494c000 b498f000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b4997000 b49a4000 r-xp /usr/lib/libemail-common-use.so.1.1.0
b49ac000 b4a18000 r-xp /usr/lib/libemail-core.so.1.1.0
b4a29000 b4a65000 r-xp /usr/lib/libemail-storage.so.1.1.0
b4a6e000 b4a77000 r-xp /usr/lib/libemail-ipc.so.1.1.0
b4a7f000 b4a81000 r-xp /usr/lib/libdri2.so.0.0.0
b4a89000 b4a90000 r-xp /usr/lib/libdrm.so.2.4.0
b4a99000 b4a9d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4aa6000 b4ab9000 r-xp /usr/lib/libmdm.so.1.0.88
b4ac1000 b4ac7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b4ad0000 b4ada000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b4ae6000 b4aee000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4af6000 b4af8000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
b4b00000 b4b37000 r-xp /usr/lib/libpulse.so.0.16.2
b4b40000 b4b45000 r-xp /usr/lib/libmmfsession.so.0.0.0
b4b4d000 b4b62000 r-xp /usr/lib/libmmfsound.so.0.1.0
b4b6a000 b4b6d000 r-xp /usr/lib/libmm_ta.so.0.0.0
b4b75000 b4b7e000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b4b86000 b4b93000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b4b9c000 b4ba5000 r-xp /usr/lib/libcom-core.so.0.0.1
b4bad000 b4bbd000 r-xp /usr/lib/libemail-api.so.1.1.0
b4bc5000 b4bcc000 r-xp /usr/lib/libtbm.so.1.0.0
b4bd4000 b4c6f000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b4c7b000 b4c80000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4c88000 b4cd9000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b4ce7000 b4ceb000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.1.3
b4cf3000 b4cf5000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4cfd000 b4d0a000 r-xp /usr/lib/libnotification.so.0.1.0
b4d12000 b4d22000 r-xp /usr/lib/libcapi-media-camera.so.0.1.71
b4d2c000 b4d36000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4d3f000 b4d45000 r-xp /opt/usr/apps/org.tizen.watchdog/bin/watchdog
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
b6ef6000 b6ef9000 rw-p [stack:7262]
b6efa000 b6efd000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f07000 b6f0b000 r-xp /usr/lib/libsys-assert.so
b6f14000 b6f31000 r-xp /lib/ld-2.13.so
b6f3a000 b6f3f000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b8d97000 b8de0000 rw-p [heap]
b8de0000 b91f9000 rw-p [heap]
be80d000 be82e000 rw-p [stack]
be80d000 be82e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7254)
Call Stack Count: 19
 0: btn_clicked_cb + 0x4d (0xb4d42d86) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x3d86
 1: evas_object_smart_callback_call + 0x88 (0xb626e45d) [/usr/lib/libevas.so.1] + 0x3545d
 2: (0xb61baf7d) [/usr/lib/libedje.so.1] + 0x43f7d
 3: (0xb61bf955) [/usr/lib/libedje.so.1] + 0x48955
 4: (0xb61bb8d9) [/usr/lib/libedje.so.1] + 0x448d9
 5: (0xb61bbc8b) [/usr/lib/libedje.so.1] + 0x44c8b
 6: (0xb61bbdc5) [/usr/lib/libedje.so.1] + 0x44dc5
 7: (0xb6b4520d) [/usr/lib/libecore.so.1] + 0xa20d
 8: (0xb6b42c6b) [/usr/lib/libecore.so.1] + 0x7c6b
 9: (0xb6b46283) [/usr/lib/libecore.so.1] + 0xb283
10: ecore_main_loop_begin + 0x30 (0xb6b46691) [/usr/lib/libecore.so.1] + 0xb691
11: appcore_efl_main + 0x17e (0xb6efc387) [/usr/lib/libappcore-efl.so.1] + 0x2387
12: ui_app_main + 0xb0 (0xb64e0499) [/usr/lib/libcapi-appfw-application.so.0] + 0x2499
13: app_run + 0x4e (0xb4d43c27) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x4c27
14: main + 0x26 (0xb4d43f5b) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x4f5b
15: _main_view_resume_cb + 0x32 (0xb6f3cdc7) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x2dc7
16: (0xb6f3bd8f) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x1d8f
17: __libc_start_main + 0x114 (0xb6be482c) [/lib/libc.so.6] + 0x1782c
18: (0xb6f3c0d4) [/opt/usr/apps/org.tizen.watchdog/bin/watchdog] + 0x20d4
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

08-07 21:02:02.240+0530 E/VCONF   (  492): vconf.c: vconf_get_int(2379) > vconf_get_int(492) : db/ise/swiftkey/dlm/onpause_noti error
08-07 21:02:02.240+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x30 value =0x0[0m
08-07 21:02:02.240+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_helper_event(1538) > [0;33mXT9_CMD_INPUTMODE value = 14[0m
08-07 21:02:02.250+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:02.250+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:02.250+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:02.250+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:02.250+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:02.250+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:02.250+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:02.250+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:02.250+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:02.250+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
08-07 21:02:02.250+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
08-07 21:02:02.250+0530 E/VCONF   (  492): vconf.c: vconf_get_int(2379) > vconf_get_int(492) : db/ise/swiftkey/dlm/onpause_noti error
08-07 21:02:02.260+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:02.260+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:02.260+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:02.260+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:02.260+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:02.260+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:02.260+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
08-07 21:02:02.260+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
08-07 21:02:02.260+0530 E/VCONF   (  492): vconf.c: vconf_get_int(2379) > vconf_get_int(492) : db/ise/swiftkey/dlm/onpause_noti error
08-07 21:02:02.520+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:02.770+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:02:02.770+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:02:02.770+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:02:02.770+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:02:02.770+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:02:02.770+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:02:02.770+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:02:02.770+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:02:02.770+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:02:02.770+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:02:02.770+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:02:03.020+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:03.150+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(542) > [0;33mret : 41[0m
08-07 21:02:03.150+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(588) > [0;33mret = 1[0m
08-07 21:02:03.170+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(542) > [0;33mret : 41[0m
08-07 21:02:03.170+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(588) > [0;33mret = 0[0m
08-07 21:02:03.170+0530 I/ISE_MULTI(  492): isemain.cpp: slot_update_cursor_position(868) > [0;36m[hidden state:false] pos=10[0m
08-07 21:02:03.520+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:03.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x90 value =0x0[0m
08-07 21:02:03.590+0530 W/IME_LITE(  487): xldb.cpp: UIReadAWLdbData(118) > [0;33mwLdbNum = 0x109[0m
08-07 21:02:03.590+0530 W/IME_LITE(  487): xldb.cpp: UIReadAWLdbData(118) > [0;33mwLdbNum = 0x109[0m
08-07 21:02:03.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0xff02 value =0x1[0m
08-07 21:02:03.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0xff03 value =0x1[0m
08-07 21:02:03.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0xff04 value =0x1[0m
08-07 21:02:03.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0xff05 value =0x1[0m
08-07 21:02:03.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0xff06 value =0x0[0m
08-07 21:02:03.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0xff07 value =0x1[0m
08-07 21:02:03.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0xff08 value =0x1[0m
08-07 21:02:03.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0xff09 value =0x0[0m
08-07 21:02:03.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0xff0a value =0x1[0m
08-07 21:02:03.590+0530 I/IME_LITE(  487): selectpage.cpp: ResetSelection(28) > [0;36m[0m
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:03.610+0530 W/ISF_PANEL_EFL(  491): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x1200003 FAILED!
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: vconf_get_int(2379) > vconf_get_int(492) : db/ise/swiftkey/dlm/onpause_noti error
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:03.610+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:03.620+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.620+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
08-07 21:02:03.620+0530 E/VCONF   (  492): vconf.c: vconf_get_int(2379) > vconf_get_int(492) : db/ise/swiftkey/dlm/onpause_noti error
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: vconf_get_int(2379) > vconf_get_int(492) : db/ise/swiftkey/dlm/onpause_noti error
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/setting/homescreen/easymode) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/setting/homescreen/easymode : read buf error(-21). break
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: vconf_get_bool(2417) > vconf_get_bool(492) : db/setting/homescreen/easymode error
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key_filesys(2020) > _vconf_get_key_filesys(0-db/ise/swiftkey/dlm/onpause_noti) step(-21) failed(2 / No such file or directory)
08-07 21:02:03.630+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x30 value =0x0[0m
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: _vconf_get_key(2111) > db/ise/swiftkey/dlm/onpause_noti : read buf error(-21). break
08-07 21:02:03.630+0530 E/VCONF   (  492): vconf.c: vconf_get_int(2379) > vconf_get_int(492) : db/ise/swiftkey/dlm/onpause_noti error
08-07 21:02:03.630+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_helper_event(1538) > [0;33mXT9_CMD_INPUTMODE value = 24[0m
08-07 21:02:03.800+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:02:04.020+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:04.440+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x400 value =0xffffffff[0m
08-07 21:02:04.440+0530 E/IME_LITE(  487): isf_xt9_imengine.cpp: process_helper_event(1685) > [0;31munknow cmd=0x400[0m
08-07 21:02:04.450+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(542) > [0;33mret : 41[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:04.470+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(588) > [0;33mret = 0[0m
08-07 21:02:04.520+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:04.840+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:02:04.840+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:02:04.840+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:02:04.840+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:02:04.840+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:02:04.840+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:02:04.840+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:02:04.840+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:02:04.840+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:02:04.840+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:02:04.840+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:02:05.030+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x400 value =0xffffffff[0m
08-07 21:02:05.030+0530 E/IME_LITE(  487): isf_xt9_imengine.cpp: process_helper_event(1685) > [0;31munknow cmd=0x400[0m
08-07 21:02:05.030+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:05.030+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(542) > [0;33mret : 41[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.060+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(588) > [0;33mret = 0[0m
08-07 21:02:05.530+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:05.550+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x400 value =0xffffffff[0m
08-07 21:02:05.550+0530 E/IME_LITE(  487): isf_xt9_imengine.cpp: process_helper_event(1685) > [0;31munknow cmd=0x400[0m
08-07 21:02:05.560+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(542) > [0;33mret : 41[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.570+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:05.580+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(588) > [0;33mret = 0[0m
08-07 21:02:05.870+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:02:06.030+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:06.160+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x400 value =0xffffffff[0m
08-07 21:02:06.160+0530 E/IME_LITE(  487): isf_xt9_imengine.cpp: process_helper_event(1685) > [0;31munknow cmd=0x400[0m
08-07 21:02:06.160+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(542) > [0;33mret : 41[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.180+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(588) > [0;33mret = 0[0m
08-07 21:02:06.530+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:06.720+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x400 value =0xffffffff[0m
08-07 21:02:06.720+0530 E/IME_LITE(  487): isf_xt9_imengine.cpp: process_helper_event(1685) > [0;31munknow cmd=0x400[0m
08-07 21:02:06.730+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(542) > [0;33mret : 41[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:06.740+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(588) > [0;33mret = 0[0m
08-07 21:02:06.900+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:02:06.900+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:02:06.910+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:02:06.910+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:02:06.910+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:02:06.910+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:02:06.910+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:02:06.910+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:02:06.910+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:02:06.910+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:02:06.910+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:02:07.030+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:07.210+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(542) > [0;33mret : 41[0m
08-07 21:02:07.210+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(588) > [0;33mret = 0[0m
08-07 21:02:07.220+0530 I/ISE_MULTI(  492): isemain.cpp: slot_update_cursor_position(868) > [0;36m[hidden state:false] pos=16[0m
08-07 21:02:07.530+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:07.940+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:02:08.030+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:08.530+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x400 value =0xffffffff[0m
08-07 21:02:08.530+0530 E/IME_LITE(  487): isf_xt9_imengine.cpp: process_helper_event(1685) > [0;31munknow cmd=0x400[0m
08-07 21:02:08.540+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:08.540+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(542) > [0;33mret : 41[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:08.580+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(588) > [0;33mret = 0[0m
08-07 21:02:08.980+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:02:08.980+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:02:08.980+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:02:08.980+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:02:08.980+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:02:08.990+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:02:08.990+0530 I/Tizen::System( 1053): (184) > Required command is [osp.sys.ipcserver.setting_service.command.get.bool].
08-07 21:02:08.990+0530 I/Tizen::System( 1053): (425) > Command Code is osp.sys.ipcserver.setting_service.command.get.bool.
08-07 21:02:08.990+0530 I/Tizen::System( 1053): (426) > Result Code is E_SUCCESS.
08-07 21:02:08.990+0530 I/Tizen::System( 1053): (432) > Value is 1.
08-07 21:02:08.990+0530 I/Tizen::System( 1120): (637) > result is 1.
08-07 21:02:09.020+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x400 value =0xffffffff[0m
08-07 21:02:09.020+0530 E/IME_LITE(  487): isf_xt9_imengine.cpp: process_helper_event(1685) > [0;31munknow cmd=0x400[0m
08-07 21:02:09.020+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(542) > [0;33mret : 41[0m
08-07 21:02:09.030+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.080+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(588) > [0;33mret = 0[0m
08-07 21:02:09.530+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:09.720+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x400 value =0xffffffff[0m
08-07 21:02:09.720+0530 E/IME_LITE(  487): isf_xt9_imengine.cpp: process_helper_event(1685) > [0;31munknow cmd=0x400[0m
08-07 21:02:09.730+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(542) > [0;33mret : 41[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 E/IME_LITE(  487): selectpage.cpp: FillAWPage(340) > [0;31mstatus = 0[0m
08-07 21:02:09.750+0530 W/IME_LITE(  487): isf_xt9_imengine.cpp: process_specific_key_event(588) > [0;33mret = 0[0m
08-07 21:02:10.020+0530 E/LOCATION( 1120): location-privacy.c: location_get_privacy(174) > CPPAPP use location
08-07 21:02:10.030+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:10.540+0530 E/SurfaceFlinger( 1575): redraw failed: empty invalid region
08-07 21:02:10.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x90 value =0x0[0m
08-07 21:02:10.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x90 value =0x0[0m
08-07 21:02:10.590+0530 I/IME_LITE(  487): westerneuropeandusxt9.cpp: _HelperCommandEvent(440) > [0;36mcmd = 0x90 value =0x0[0m
08-07 21:02:10.600+0530 I/camerasample( 7254): Email registered by user: Chenyemh2@gmail.com
08-07 21:02:10.600+0530 I/ISE_MULTI(  492): isemain.cpp: slot_reset_ise_input_context(1035) > [0;36m[hidden state:false][0m
08-07 21:02:10.900+0530 W/AUL_AMD (  455): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-07 21:02:10.900+0530 W/AUL_AMD (  455): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-07 21:02:10.920+0530 W/ISF_PANEL_EFL(  491): isf_panel_efl.cpp: efl_get_window_rotate_angle(3349) > WINDOW angle of 0x7e00003 FAILED!
08-07 21:02:10.960+0530 I/AUL_PAD (  504): sigchild.h: __launchpad_sig_child(142) > dead_pid = 7254 pgid = 7254
08-07 21:02:10.960+0530 I/AUL_PAD (  504): sigchild.h: __sigchild_action(123) > dead_pid(7254)
08-07 21:02:10.960+0530 I/AUL_PAD (  504): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-07 21:02:10.960+0530 I/AUL_PAD (  504): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-07 21:02:10.960+0530 I/Tizen::System( 1053): (246) > Terminated app [org.tizen.watchdog]
08-07 21:02:10.960+0530 I/Tizen::Io( 1053): (729) > Entry not found
08-07 21:02:10.960+0530 I/Tizen::App(  999): (243) > App[org.tizen.watchdog] pid[7254] terminate event is forwarded
08-07 21:02:10.960+0530 I/Tizen::System(  999): (256) > osp.accessorymanager.service provider is found.
08-07 21:02:10.960+0530 I/Tizen::System(  999): (196) > Accessory Owner is removed [org.tizen.watchdog, 7254, ]
08-07 21:02:10.960+0530 I/Tizen::System(  999): (256) > osp.system.service provider is found.
08-07 21:02:10.960+0530 I/Tizen::App(  999): (506) > TerminatedApp(org.tizen.watchdog)
08-07 21:02:10.970+0530 I/Tizen::App(  999): (512) > Not registered pid(7254)
08-07 21:02:10.970+0530 I/Tizen::App(  999): (782) > Finished invoking application event listener for org.tizen.watchdog, 7254.
08-07 21:02:10.970+0530 I/AUL_AMD (  455): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 7254
08-07 21:02:10.970+0530 I/Tizen::System( 1053): (157) > change brightness system value.
08-07 21:02:10.970+0530 I/Tizen::App( 1053): (782) > Finished invoking application event listener for org.tizen.watchdog, 7254.
08-07 21:02:10.980+0530 W/PROCESSMGR(  343): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=604
08-07 21:02:11.000+0530 W/AUL_AMD (  455): amd_request.c: __request_handler(601) > __request_handler: 15
08-07 21:02:11.010+0530 I/CAPI_APPFW_APPLICATION(  604): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-07 21:02:11.010+0530 E/cluster-home(  604): homescreen-main.cpp: app_resume(422) >  app resume
08-07 21:02:11.020+0530 W/CRASH_MANAGER( 9240): worker.c: worker_job(1236) > 1107254776174143896153
